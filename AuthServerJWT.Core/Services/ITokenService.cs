using AuthServerJWT.Core.Configuration;
using AuthServerJWT.Core.Dtos;
using AuthServerJWT.Core.Entity;

namespace AuthServerJWT.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}
