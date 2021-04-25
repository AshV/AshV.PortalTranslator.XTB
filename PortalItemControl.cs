using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AshV.PortalTranslator.XTB
{
    public partial class PortalItemControl : UserControl
    {
        private Guid websiteGuid;

        public Guid WebsiteGuid
        {
            get { return websiteGuid; }
            set { websiteGuid = value; }
        }

        private string websiteName;

        public string WebsiteName
        {
            get { return websiteName; }
            set { websiteName = value; }
        }

        private string websiteLanguage;

        public string WebsiteLanguage
        {
            get { return websiteLanguage; }
            set { websiteLanguage = value; }
        }

        private string websiteLcid;

        public string WebsiteLcid
        {
            get { return websiteLcid; }
            set { websiteLcid = value; }
        }

        private string websiteUrl;

        public string WebsiteUrl
        {
            get { return websiteUrl; }
            set { websiteUrl = value; }
        }

        public PortalItemControl()
        {
            InitializeComponent();
        }

        private void PortalItemControl_Load(object sender, EventArgs e)
        {
            lblName.Text = websiteName;
            lblLanguage.Text = websiteLanguage;
            lblLcid.Text = websiteLcid;
            lblUrl.Text = websiteUrl;
            lblGuid.Text = WebsiteGuid.ToString();
        }
    }
}