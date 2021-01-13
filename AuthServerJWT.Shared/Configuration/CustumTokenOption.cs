using System;
using System.Collections.Generic;

namespace AuthServerJWT.Shared.Configuration
{
    public class CustumTokenOption
    {
        public List<String> Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public int RefreshTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
