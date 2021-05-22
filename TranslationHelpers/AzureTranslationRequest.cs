using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshV.PortalTranslator.XTB.TranslationHelpers
{
    public class AzureTranslationRequest
    {
        public string BaseText { get; set; }
        public string BaseLanguage { get; set; }
        public List<string> TargetLangauges { get; set; }
    }
}
