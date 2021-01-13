using AuthServerJWT.Core.Dtos;
using AuthServerJWT.Shared.Dtos;
using System.Threading.Tasks;

namespace AuthServerJWT.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<Response<UserAppDto>> GetUserByNameAsync(string username);

    }
}
