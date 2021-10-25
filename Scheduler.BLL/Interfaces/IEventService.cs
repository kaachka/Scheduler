using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.Interfaces
{
    public interface IEventService
    {
        Task CreateEvent(EventDTO eventDTO);

        Task<EventDTO> GetEventById(int id);
        Task<IEnumerable<EventDTO>> GetEventsByDate(DateTime dateTime);
        Task<IEnumerable<EventDTO>> GetEventsByProirity(int priorityId);
        Task<IEnumerable<EventDTO>> GetEventsByTag(int tagId);
    }
}
