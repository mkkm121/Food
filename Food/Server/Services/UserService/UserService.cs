using Food.Server.Data;
using Food.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }
        public async Task AddNewUser(UserRegister user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public async Task<UserRegister> GetUser(string Email)
        {
            UserRegister user = await _context.Users.FirstOrDefaultAsync(p => p.Email == Email);
            return user;
        }
    }
}
