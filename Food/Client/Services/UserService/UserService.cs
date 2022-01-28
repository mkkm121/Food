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

        public UserService(HttpClient httpClient) {
            this.httpClient = httpClient;
        }
        /*
        public async Task CreateUser()
        {
           // return await httpClient.PostAsJsonAsync<User>("api/users");
        }

        public async Task<User> GetUser(int id)
        {
            //return await httpClient.PostJsonAsync<User>("api/users/{id}");
            return true;
        }
        */
    }
}
