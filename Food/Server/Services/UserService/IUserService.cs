using Food.Shared;
using System;
using System.Threading.Tasks;

namespace Food.Server.Services.UserService
{
    public interface IUserService
    {
        Task AddNewUser(UserRegister user);
        Task UpdateUserPassword(ChangePassword change);
        Task<UserRegister> GetUser(string Email);

        String sha256_hash(String value);
    }
}
