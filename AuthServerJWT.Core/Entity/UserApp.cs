using Microsoft.AspNetCore.Identity;

namespace AuthServerJWT.Core.Entity
{
    public class UserApp:IdentityUser
    {
        public string City { get; set; }
    }
}
