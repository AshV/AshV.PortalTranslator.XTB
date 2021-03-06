using Newtonsoft.Json;
using System.Collections.Generic;

namespace AshV.PortalTranslator.XTB.TranslationHelpers
{
    public class LanguageInfo
    {
        public string Name { get; set; }
        public int LCID { get; set; }
        public string Locale { get; set; }
        public string AzureCode { get; set; }
    }

    public class LanguageInfoHelper
    {
        public static List<LanguageInfo> Languages { get; set; }
        static string langJson = @"[{'Name':'Arabic','LCID':1025,'Locale':'ar-SA'},{'Name':'Basque(Basque)','LCID':1069,'Locale':'eu-ES'},{'Name':'Bulgarian(Bulgaria)','LCID':1026,'Locale':'bg-BG'},{'Name':'Catalan(Catalan)','LCID':1027,'Locale':'ca-ES'},{'Name':'Chinese(Hong Kong S.A.R.)','LCID':3076,'Locale':'zh-HK'},{'Name':'Chinese(PRC)','LCID':2052,'Locale':'zh-CN'},{'Name':'Chinese(Taiwan)','LCID':1028,'Locale':'zh-TW'},{'Name':'Croatian(Croatia)','LCID':1050,'Locale':'hr-HR'},{'Name':'Czech','LCID':1029,'Locale':'cs-CZ'},{'Name':'Danish','LCID':1030,'Locale':'da-DK'},{'Name':'Dutch','LCID':1043,'Locale':'nl-NL'},{'Name':'Estonian(Estonia)','LCID':1061,'Locale':'et-EE'},{'Name':'Finnish','LCID':1035,'Locale':'gi-FI'},{'Name':'French','LCID':1036,'Locale':'fr-FR'},{'Name':'GalicianGalician)','LCID':1110,'Locale':'gl-ES'},{'Name':'German','LCID':1031,'Locale':'de-DE'},{'Name':'Greek','LCID':1032,'Locale':'el-GR'},{'Name':'Hebrew','LCID':1037,'Locale':'he-IL'},{'Name':'Hindi(India)','LCID':1081,'Locale':'hi-IN'},{'Name':'Hungarian','LCID':1038,'Locale':'hu-HU'},{'Name':'Indonesian','LCID':1057,'Locale':'id-ID'},{'Name':'Italian','LCID':1040,'Locale':'it-IT'},{'Name':'Japanese','LCID':1041,'Locale':'ja-JP'},{'Name':'Kazakh(Kazakhstan)','LCID':1087,'Locale':'kk-KZ'},{'Name':'Korean','LCID':1042,'Locale':'ko-KR'},{'Name':'Latvian(Latvia)','LCID':1062,'Locale':'lv-LV'},{'Name':'Lithuanian(Lithuania)','LCID':1063,'Locale':'lt-LT'},{'Name':'Malay','LCID':1086,'Locale':'ms-MY'},{'Name':'Norwegian(Bokm�l)','LCID':1044,'Locale':'nb-NO'},{'Name':'Polish','LCID':1045,'Locale':'pl-PL'},{'Name':'Portuguese(Brazil)','LCID':1046,'Locale':'pt-BR'},{'Name':'Portuguese(Portugal)','LCID':2070,'Locale':'pt-PT'},{'Name':'Romanian(Romania)','LCID':1048,'Locale':'ro-RO'},{'Name':'Russian','LCID':1049,'Locale':'ru-RU'},{'Name':'Serbian(Cyrillic)','LCID':3098,'Locale':'sr-Cyrl-CS'},{'Name':'Serbian(Latin, Serbia)','LCID':2074,'Locale':'sr-Latn-CS'},{'Name':'Slovak(Slovakia)','LCID':1051,'Locale':'sk-SK'},{'Name':'Slovenian(Slovenia)','LCID':1060,'Locale':'sl-SI'},{'Name':'Spanish','LCID':3082,'Locale':'es-ES'},{'Name':'Swedish','LCID':1053,'Locale':'sv-SE'},{'Name':'Thai','LCID':1054,'Locale':'th-TH'},{'Name':'Turkish','LCID':1055,'Locale':'tr-TR'},{'Name':'Ukrainian(Ukraine)','LCID':1058,'Locale':'uk-UA'},{'Name':'Vietnamese','LCID':1066,'Locale':'vi-VN'}]";
        static LanguageInfoHelper()
        {
            Languages = new List<LanguageInfo>();
            Languages = JsonConvert.DeserializeObject<List<LanguageInfo>>(langJson);
        }

        public static LanguageInfo GetLanguage(int lcid)
        {
            return Languages.Find(lang => lang.LCID == lcid);
        }

        public  static LanguageInfo GetLanguage(string locale)
        {
            return Languages.Find(lang => lang.Locale.Equals(locale));
        }

        public static LanguageInfo GetLanguageFromAzureCode(string azureCode)
        {
            return Languages.Find(lang => lang.AzureCode.Equals(azureCode));
        }
    }
}