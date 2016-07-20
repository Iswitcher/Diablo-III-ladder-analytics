using System;

namespace Diablo_III_ladder_analytics.JsonStructs
{
    public class TokenJson
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
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
