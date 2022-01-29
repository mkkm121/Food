using Food.Shared;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Food.Client.Services.UserService
{
    public interface IUserService
    {
        Task CreateUser(UserRegister user);
        Task<UserRegister> LoginUser(string Email);
    }
}
