using System;
using System.IO;
using System.Net;
using System.Web;

namespace Diablo_III_ladder_analytics.Classes
{
    public static class WebRequestsController
    {
        public static void RequestData(string requestUrl)
        {
            
        }

        public static string RequestToken(string clientId, string clientSecret)
        {
            string token = "";
            string requestUrlTemplate = ApplicationSettings.Default.BlizzTokenRequestUrl;

            string requestUrl = string.Format(requestUrlTemplate, clientId, clientSecret);
            var rawText = SendWebRequest(requestUrl);



            return token;
        }

        private static string SendWebRequest(string requestUrl)
        {
            string responseText = "";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(requestUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream s = response.GetResponseStream())
            {
                using (TextReader textReader = new StreamReader(s, true))
                {
                    responseText = textReader.ReadToEnd();
                }
            }
            return responseText;
        }
    }
}
