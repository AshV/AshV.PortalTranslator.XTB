using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AshV.PortalTranslator.XTB.TranslationHelpers
{
    partial class AzureTranslator : ITranslator
    {
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com/translate";
        private static readonly string apiVersion = "api-version=3.0";
        private static readonly string location = "global";

        public TranslationResult GetTranslation(TranslationRequest translationRequest)
        {
            var request = translationRequest.ToAzureTranslationRequest();
            var result = InvokeTranslateAPI(request).Result;
            if (result.Success)
                return ParseResponse(result.HttpResponseBody, translationRequest);
            else
                return new TranslationResult
                {
                    Success = false,
                    ErrorMessage = result.HttpResponseBody
                };
        }

        private string PrepareQueryString(AzureTranslationRequest request)
        {
            var parts = new List<string>();
            parts.Add(apiVersion);
            parts.Add($"from={request.BaseLanguage}");
            request.TargetLangauges.ForEach(lang => { parts.Add($"to={lang}"); });
            return string.Join("&", parts);
        }

        private async Task<(bool Success, string HttpResponseBody)> InvokeTranslateAPI(AzureTranslationRequest azureTranslationRequest)
        {
            string url = endpoint + "?" + PrepareQueryString(azureTranslationRequest);
            string textToTranslate = azureTranslationRequest.BaseText;
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(url);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                // Read response as a string.
                string result = await response.Content.ReadAsStringAsync();
                return (response.IsSuccessStatusCode, result);
            }
        }

        private TranslationResult ParseResponse(string httpResponseBody, TranslationRequest request)
        {
            var translationResult = new TranslationResult
            {
                BaseLanguage = request.BaseLanguage,
                BaseText = request.BaseText,
                Success = true,
                TranslatedText = new Dictionary<int, string>()
            };

            var azureTranslationResponse = JsonConvert.DeserializeObject<AzureTranslationResponse>(httpResponseBody);

            azureTranslationResponse.Root[0].translations.ToList().ForEach(result =>
            {
                translationResult.TranslatedText.Add(LanguageInfoHelper.GetLanguageFromAzureCode(result.to).LCID, result.text);
            });

            return translationResult;
        }
    }
}