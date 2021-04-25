﻿using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace AshV.PortalTranslator.XTB
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        private Guid CurrentWebsite;

        public Guid CurrentSnippetGuid;
        public string CurrentSnippetDispalyName;
        public string CurrentSnippetValue;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }

            OnLoadAppearance();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            ExecuteMethod(GetWebsites);
        }

        public void GetWebsites()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving portal's list...",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(
                        new FetchExpression(
                        @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                            <entity name='adx_website'>
                              <attribute name='adx_websiteid' />
                              <attribute name='adx_primarydomainname' />
                              <attribute name='adx_name' />
                              <attribute name='adx_website_language' />
                              <link-entity name='adx_websitelanguage' from='adx_websitelanguageid' to='adx_defaultlanguage' visible='false' link-type='outer' alias='lang'>
                                <attribute name='adx_portallanguageid' />
                                <attribute name='adx_name' />
                              </link-entity>
                            </entity>
                          </fetch>"));
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        if (result.TotalRecordCount == 0)
                            MessageBox.Show("No Portals found is this environment.");

                        flLeftPane.Controls.Clear();

                        result.Entities.ToList().ForEach(website =>
                        {
                            var portalItem = new PortalItemControl();
                            portalItem.WebsiteGuid = website.Id;
                            portalItem.WebsiteName = website.GetAttributeValue<string>("adx_name");
                            portalItem.WebsiteLcid = website.GetAttributeValue<int>("adx_website_language").ToString();
                            portalItem.WebsiteLanguage = website.GetAttributeValue<AliasedValue>("lang.adx_name").Value.ToString();
                            portalItem.WebsiteUrl = website.GetAttributeValue<string>("adx_primarydomainname");
                            portalItem.Click += new EventHandler((object sender, EventArgs e) =>
                            {
                                MessageBox.Show(portalItem.WebsiteGuid.ToString());
                                CurrentWebsite = portalItem.WebsiteGuid;
                                ExecuteMethod(GetContentSnippets);
                            });

                            portalItem.Width = flLeftPane.Width - 5;

                            flLeftPane.Controls.Add(portalItem);
                        });

                    }
                }
            });
        }

        private void GetContentSnippets()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving content snippets...",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(
                        new FetchExpression(string.Format(
                        @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                            <entity name='adx_contentsnippet'>
                              <attribute name='adx_contentsnippetid' />
                              <attribute name='adx_name' />
                              <attribute name='adx_type' />
                              <order attribute='adx_name' descending='false' />
                              <filter type='and'>
                                <condition attribute='adx_websiteid' operator='eq' value='{0}' />
                              </filter>
                            </entity>
                          </fetch>", CurrentWebsite)));
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        if (result.TotalRecordCount == 0)
                            MessageBox.Show("No content snippets found for this portal.");

                        flLeftPane.Controls.Clear();

                        result.Entities.GroupBy(gb => gb.GetAttributeValue<string>("adx_name")).ToList().ForEach(snippet =>
                        {
                            var snippetItem = new ContentSnippetItemControl();
                            snippetItem.SnippetName = snippet.Key;
                            snippetItem.LanguageCount = snippet.Count();
                            snippetItem.Click += new EventHandler((object sender, EventArgs e) => { MessageBox.Show(snippetItem.SnippetName.ToString()); });
                            snippetItem.Width = flLeftPane.Width - 25;

                            flLeftPane.Controls.Add(snippetItem);
                        });
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void OnLoadAppearance()
        {
            flpRightMain.Controls.Add(new EditSnippetControl()
            {
                Parent = this,
                DisplayName = "Text",
                ValueType = "ds",
                SnippetLanguage = "Hindi",
                SnippetValue = "Hahahha!"
            });

        }
    }
}