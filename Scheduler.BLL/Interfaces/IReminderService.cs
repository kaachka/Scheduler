using Scheduler.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scheduler.BLL.Interfaces
{
    public interface IReminderService
    {
        Task CreateReminder(ReminderDTO reminderDTO);

        Task<ReminderDTO> GetReminderById(int id);
        Task<IEnumerable<ReminderDTO>> GetReminderByStart(DateTime start);
        Task<IEnumerable<ReminderDTO>> GetReminderByEnd(DateTime end);
    }
}
