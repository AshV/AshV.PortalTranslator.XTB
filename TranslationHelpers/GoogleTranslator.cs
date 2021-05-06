using Google.Cloud.Translate.V3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshV.PortalTranslator.XTB.TranslationHelpers
{
    partial class GoogleTranslator : ITranslator
    {
        public GoogleTranslator()
        {
            TranslationServiceClientBuilder s = new TranslationServiceClientBuilder();
            s.JsonCredentials = Key;
            var client = s.Build();
        }

        public TranslationResult GetTranslation(TranslationRequest translationRequest)
        {
            throw new NotImplementedException();
        }
    }
}
