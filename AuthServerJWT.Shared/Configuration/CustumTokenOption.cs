using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServerJWT.Shared.Configuration
{
    public class CustumTokenOption
    {
        public List<String> Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiraation { get; set; }
        public int RefreshTokenExpiraation { get; set; }
        public string SecurityKey { get; set; }
    }
}
