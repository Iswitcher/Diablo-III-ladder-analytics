using System.Text;
using Newtonsoft.Json;
using Diablo_III_ladder_analytics.JsonStructs;

namespace Diablo_III_ladder_analytics.Classes
{
    public enum JsonTypes { Token=1 }

    public static class JsonParser
    {
        public static object ParseJson(string json, int jsonType)
        {
            switch (jsonType)
            {
                case (int)JsonTypes.Token :
                    return ParseTokenJson(json);
                default:
                    return new StringBuilder("Wrong json type selected: {0}",jsonType);
            }
        }

        private static TokenJson ParseTokenJson(string tokenJson)
        {
            TokenJson token = new TokenJson();
            token = JsonConvert.DeserializeObject<TokenJson>(tokenJson);
            return token;
        }
    }
}
