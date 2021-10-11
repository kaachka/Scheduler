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
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IEventService _eventService;
        private readonly IUserService _userService;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, IEventService eventService, IUserService userService)
        {
            _logger = logger;
            _eventService = eventService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<EventDTO>> Get(DateTime dateTime)
        {
            return await _eventService.GetEvents(dateTime);
        }

        [HttpGet]
        public void CreateUser(string login, string email)
        {
            _userService.CreateUser(login, email);
        }

        [HttpGet]
        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            return await _userService.GetUsers();
        }
    }
}