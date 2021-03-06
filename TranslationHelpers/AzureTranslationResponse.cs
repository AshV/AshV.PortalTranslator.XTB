using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshV.PortalTranslator.XTB.TranslationHelpers
{
    // [{"translations":[{"text":"Hallo Welt!","to":"de"},{"text":"Salve, mondo!","to":"it"}]}]
    public class AzureTranslationResponse
    {
        public Root[] Root { get; set; }
    }

    public class Root
    {
        public Translation[] translations { get; set; }
    }

    public class Translation
    {
        public string text { get; set; }
        public string to { get; set; }
    }

}
