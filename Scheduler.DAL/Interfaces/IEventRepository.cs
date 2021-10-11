using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scheduler.DAL.Interfaces
{
    public interface IEventRepository : IRepository<Event>
    {
        Task<IEnumerable<Event>> GetEventsByUser(int userId);
        Task<IEnumerable<Event>> GetEventsByTag(int tagId);
        Task<IEnumerable<Event>> GetEventsByProirity(int priorityId);
        Task<IEnumerable<Event>> GetEventsByDate(DateTime date);
    }
}
