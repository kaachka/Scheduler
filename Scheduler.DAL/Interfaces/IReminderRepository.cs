using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.DAL.Interfaces
{
    public interface IReminderRepository : IRepository<Reminder>
    {
        Task<IEnumerable<Reminder>> GetReminderByStart(DateTime start);
        Task<IEnumerable<Reminder>> GetReminderByEnd(DateTime end);
    }
}
