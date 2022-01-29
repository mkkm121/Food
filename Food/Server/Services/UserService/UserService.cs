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
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        public async Task<UserRegister> GetUser(string Email)
        {
            string[] subs = Email.Split(' ');

            UserRegister user2 = new UserRegister { Name = "demo1234", Password = "demo1234", Email = "demo1234@asd.pl", City = "demo1234", Phone = "demo1234", PostCode = "demo1234", Street = "demo1234" };
            UserRegister user = await _context.Users.FirstOrDefaultAsync(p => p.Email == subs[0] && p.Password == subs[1]);
            if (user!=null)
                return user;
            else
                return user2;
        }

    }
}
