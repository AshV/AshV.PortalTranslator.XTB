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
    public partial class ContentSnippetItemControl : UserControl
    {
        private string name;

        public string SnippetName
        {
            get { return name; }
            set { name = value; }
        }

        private int languageCount;

        public int LanguageCount
        {
            get { return languageCount; }
            set { languageCount = value; }
        }

        public ContentSnippetItemControl()
        {
            InitializeComponent();
        }

        private void ContentSnippetItemControl_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblLangCount.Text = languageCount + lblLangCount.Text;
        }
    }
}
