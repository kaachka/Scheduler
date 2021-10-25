using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.DAL.Interfaces
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
        Task<IEnumerable<Event>> GetEventsByUser(int id);
    }
}
