using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServerJWT.Core.Entity
{
    public class UserApp:IdentityUser
    {
        public string City { get; set; }
    }
}
