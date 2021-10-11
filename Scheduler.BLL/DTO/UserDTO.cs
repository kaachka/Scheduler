using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }

        //public List<EventDTO> Events { get; set; }
        //public List<ScheduleDTO> Schedules { get; set; }
    }
}
