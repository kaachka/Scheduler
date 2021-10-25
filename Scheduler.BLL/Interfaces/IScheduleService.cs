using Scheduler.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.Interfaces
{
    public interface IScheduleService
    {
        Task Add(int userId, int eventId);

        Task<IEnumerable<EventDTO>> GetEventsByUser(int id);
    }
}
