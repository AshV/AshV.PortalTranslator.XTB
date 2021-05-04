using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshV.PortalTranslator.XTB
{
    class TranslationHelper
    {
    }

    class GoogleTranslate : ITranslator
    {
        public TranslationResult GetTranslation(TranslationRequest translationRequest)
        {
            var obj = new GTrans.GTranslate();
            var res = obj.GetTranslation(new GTrans.GTranslate.TranslationRequest
            {
                BaseLanguage = translationRequest.BaseLanguage,
                BaseText = translationRequest.BaseText,
                TargetLangauges = translationRequest.TargetLangauges
            });

            return new TranslationResult
            {
                BaseLanguage = res.BaseLanguage,
                BaseText = res.BaseText,
                Success = res.Success,
                TranslatedText = res.TranslatedText
            };
        }
    }
}
