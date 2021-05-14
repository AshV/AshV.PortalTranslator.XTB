/*
using Google.Api.Gax.ResourceNames;
using Google.Cloud.Translate.V3;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshV.PortalTranslator.XTB.TranslationHelpers
{
    partial class GoogleTranslator : ITranslator
    {
        string projectId;
        TranslationServiceClient translationServiceClient;
        public GoogleTranslator()
        {
            TranslationServiceClientBuilder translationServiceClientBuilder = new TranslationServiceClientBuilder();
            translationServiceClientBuilder.JsonCredentials = Key;
            projectId = JsonConvert.DeserializeObject<GKey>(Key).project_id;
            translationServiceClient = translationServiceClientBuilder.Build();
        }

        public TranslationResult GetTranslation(TranslationRequest translationRequest)
        {
            var result = new TranslationResult();
            result.BaseText = translationRequest.BaseText;
            result.TranslatedText = new Dictionary<int, string>();
            if (translationRequest.BaseLanguage != 0)
                result.BaseLanguage = translationRequest.BaseLanguage;

            translationRequest.TargetLangauges.ToList().ForEach(lang =>
            {
                TranslateTextRequest request = new TranslateTextRequest
                {
                    Contents = { translationRequest.BaseText },
                    TargetLanguageCode = LanguageInfoHelper.GetLanguage(lang).Locale,
                    Parent = new ProjectName(projectId).ToString(),
                };

                TranslateTextResponse response = translationServiceClient.TranslateText(request);
                // response.Translations will have one entry, because request.Contents has one entry.
                Translation translation = response.Translations[0];
                //Console.WriteLine($"Detected language: {translation.DetectedLanguageCode}");
                //Console.WriteLine($"Translated text: {translation.TranslatedText}");
                result.TranslatedText.Add(lang, translation.TranslatedText);
            });

            result.Success = true;
            return result;
        }
    }


    public class GKey
    {
        public string project_id { get; set; }
    }

}
*/