using Food.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Food.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;
        public List<UserLogin> user { get; set; } = new List<UserLogin>();
        public event Action OnChange;
        public UserService(HttpClient httpClient) {
            this.httpClient = httpClient;
        }
        public async Task CreateUser(UserRegister user)
        {
            await httpClient.PostAsJsonAsync<UserRegister>("api/User", user);
            OnChange.Invoke();
        }
        public async Task<UserRegister> LoginUser(string Email)
        {
            return await httpClient.GetFromJsonAsync<UserRegister>($"api/User/{Email}");
        }

    }
}
