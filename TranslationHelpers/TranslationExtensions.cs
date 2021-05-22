using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshV.PortalTranslator.XTB.TranslationHelpers
{
    public static class TranslationExtensions
    {
        public static AzureTranslationRequest ToAzureTranslationRequest(this TranslationRequest request)
        {
            var azureTranslationRequest = new AzureTranslationRequest
            {
                BaseText = request.BaseText,
                BaseLanguage = LanguageInfoHelper.GetLanguage(request.BaseLanguage).AzureCode,
                TargetLangauges = new List<string>()
            };

            request.TargetLangauges.ForEach(lang =>
            {
                azureTranslationRequest.TargetLangauges.Add(LanguageInfoHelper.GetLanguage(lang).AzureCode);
            });

            return azureTranslationRequest;
        }
    }
}