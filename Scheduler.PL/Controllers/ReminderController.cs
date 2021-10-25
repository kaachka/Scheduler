using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Scheduler.BLL.Interfaces;
using Scheduler.BLL.DTO;
using Scheduler.DAL.DataBase;

namespace Scheduler.PL.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ReminderController : ControllerBase
    {
        private readonly IReminderService _reminderService;

        public ReminderController(IReminderService reminderService)
        {
            _reminderService = reminderService;
        }

        [HttpGet]
        public async Task<ReminderDTO> GetReminderById(int id)
        {
            return await _reminderService.GetReminderById(id);
        }

        [HttpGet]
        public async Task<IEnumerable<ReminderDTO>> GetReminderByStart(DateTime start)
        {
            return await _reminderService.GetReminderByStart(start);
        }

        [HttpGet]
        public async Task<IEnumerable<ReminderDTO>> GetReminderByEnd(DateTime end)
        {
            return await _reminderService.GetReminderByEnd(end);
        }

        [HttpPost]
        public async Task Create(ReminderDTO reminderDTO)
        {
            await _reminderService.CreateReminder(reminderDTO);
        }
    }
}