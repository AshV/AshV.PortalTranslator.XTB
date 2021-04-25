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
    public partial class EditSnippetControl : UserControl
    {
        public MyPluginControl Parent { get; set; }

        public Guid RecordGuid { get; set; }

        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private string valueType;

        public string ValueType
        {
            get { return valueType; }
            set { valueType = value; }
        }

        private string snippetLanguage;

        public string SnippetLanguage
        {
            get { return snippetLanguage; }
            set { snippetLanguage = value; }
        }

        private string snippetValue;

        public string SnippetValue
        {
            get { return snippetValue; }
            set { snippetValue = value; }
        }

        public EditSnippetControl()
        {
            InitializeComponent();
        }

        private void EditSnippetControl_Load(object sender, EventArgs e)
        {
            txtDisplayName.Text = displayName;
            lblType.Text = valueType;
            lblLanguage.Text = snippetLanguage;
            txtValue.Text = snippetValue;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Parent.ExecuteMethod(Parent.GetWebsites);
        }
    }
}
