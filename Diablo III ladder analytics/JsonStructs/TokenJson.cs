using System;
using Newtonsoft.Json;

namespace Diablo_III_ladder_analytics.JsonStructs
{
    public class TokenJson
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        public override string ToString()
        {
            System.DateTime expirationDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            expirationDate = expirationDate.AddSeconds(ExpiresIn).ToLocalTime();

            return "access_token = " + AccessToken +
                   "\ntoken_type = " + TokenType +
                   "\nexpires_in = " + expirationDate;
        }
    }
}
