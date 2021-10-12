using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.DTO
{
    public class ReminderDTO
    {
        public int Id { get; set; }
        public DateTime StartRemind { get; set; }
        public DateTime EndRemind { get; set; }
    }
}
