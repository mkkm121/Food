using Food.Shared;
using System.Threading.Tasks;

namespace Food.Server.Services.UserService
{
    public interface IUserService
    {
        Task AddNewUser(UserRegister user);
        Task<UserRegister> GetUser(string Email);
    }
}
