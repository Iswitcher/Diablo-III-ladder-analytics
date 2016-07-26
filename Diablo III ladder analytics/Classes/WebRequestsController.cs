using System.Web;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;


namespace Diablo_III_ladder_analytics.Classes
{
    public static class WebRequestsController
    {
        public static void RequestData(string requestUrl)
        {
            
        }

        public static string RequestToken(string clientId, string clientSecret)
        {
            string requestUrlTemplate = ApplicationSettings.Default.BlizzTokenRequestUrl;
            string requestUrl = string.Format(requestUrlTemplate, clientId, clientSecret);
            return SendWebRequest(requestUrl, "POST"); ;
        }

        private static string SendWebRequest(string requestUrl,string requestMethod)
        {
            string responseText = "";
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(requestUrl);
            request.Method = requestMethod;
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
