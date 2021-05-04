using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshV.PortalTranslator.XTB
{
    interface ITranslator
    {
        TranslationResult GetTranslation(TranslationRequest translationRequest);
    }

    public class TranslationRequest
    {
        public string BaseText { get; set; }
        public int BaseLanguage { get; set; }
        public int[] TargetLangauges { get; set; }
    }

    public class TranslationResult
    {
        public bool Success { get; set; }
        public string BaseText { get; set; }
        public int BaseLanguage { get; set; }
        public Dictionary<int, string> TranslatedText { get; set; }
    }
}
