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
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpPost]
        public async Task Add(int userId, int eventId)
        {
            await _scheduleService.Add(userId, eventId);
        }


        [HttpGet]
        public async Task<IEnumerable<EventDTO>> GetEventsByUser(int userId)
        {
            return await _scheduleService.GetEventsByUser(userId);
        }
    }
}