using Food.Server.Data;
using Food.Server.Services.UserService;
using Food.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Food.Server.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<ActionResult<UserRegister>> PostUser(UserRegister user)
        {
            await _userService.AddNewUser(user);
            return Ok();
        }
        [HttpGet("{Email}")]
        public async Task<ActionResult<Product>> GetUser(string email)
        {
            return Ok(await _userService.GetUser(email));
        }
    }
}