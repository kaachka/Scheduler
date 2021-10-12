using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Scheduler.BLL.Interfaces;
using Scheduler.BLL.DTO;

namespace Scheduler.PL.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task CreateUser(string login, string email)
        {
            await _userService.CreateUser(login, email);
        }

        [HttpGet]
        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            return await _userService.GetUsers();
        }

        [HttpGet]
        public async Task<UserDTO> GetUserByLogin(string login)
        {
            return await _userService.GetUserByLogin(login);
        }

        [HttpGet]
        public async Task<UserDTO> GetUserByEmail(string email)
        {
            return await _userService.GetUserByEmail(email);
        }
    }
}