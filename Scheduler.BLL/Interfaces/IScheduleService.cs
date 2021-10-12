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
        Task<IEnumerable<ScheduleDTO>> GetEventsByUser(int id);
    }
}
