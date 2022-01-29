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
        public UserService(HttpClient httpClient) {
            this.httpClient = httpClient;
        }
        public async Task CreateUser(UserRegister user)
        {
            Console.WriteLine(user.Name+"User service client");
            using (HttpResponseMessage response = httpClient.PostAsJsonAsync<UserRegister>("api/User", user).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Response");
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                   
            }
            
        }
        public async Task<UserRegister> LoginUser(string Email)
        {
            return await httpClient.GetFromJsonAsync<UserRegister>($"api/User/{Email}");
        }
    }
}
