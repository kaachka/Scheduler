using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.DTO
{
    public class ScheduleDTO
    {
        public UserDTO User { get; set; }
        public int UserId { get; set; }

        public EventDTO Event { get; set; }
        public int EventId { get; set; }
    }
}
