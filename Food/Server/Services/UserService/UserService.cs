using Food.Server.Data;
using Food.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            user.Password = sha256_hash(user.Password);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateUserPassword(ChangePassword change)
        {
            UserRegister user = await _context.Users.FirstOrDefaultAsync(p => p.Email == change.Email);
            user.Password = sha256_hash(change.Password);
            _context.Update(user);
            await _context.SaveChangesAsync();
        }
        public async Task<UserRegister> GetUser(string Email)
        {
            string[] subs = Email.Split(' ');

            UserRegister user2 = new UserRegister { };
            UserRegister user = await _context.Users.FirstOrDefaultAsync(p => p.Email == subs[0] && p.Password == sha256_hash(subs[1]));
            if (user!=null)
                return user;
            else
                return user2;
        }
        public String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

    }
}
