using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServerJWT.Core.Dtos
{
    public class ClientLoginDto
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
