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
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<EventDTO> GetEventsById(int id)
        {
            return await _eventService.GetEventById(id);
        }

        [HttpGet]
        public async Task<IEnumerable<EventDTO>> GetEventsByTag(int tagId)
        {
            return await _eventService.GetEventsByTag(tagId);
        }

        [HttpGet]
        public async Task<IEnumerable<EventDTO>> GetEventsByPriority(int priorityId)
        {
            return await _eventService.GetEventsByProirity(priorityId);
        }

        [HttpGet]
        public async Task<IEnumerable<EventDTO>> GetEventsByDate(DateTime date)
        {
            return await _eventService.GetEventsByDate(date);
        }

        [HttpPost]
        public async Task Create(EventDTO eventDTO)
        {
            await _eventService.CreateEvent(eventDTO);
        }
    }
}