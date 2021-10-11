using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.DTO
{
    public class PriorityTagDTO
    {
        public int Id { get; set; }
        public string Tag { get; set; }

        public List<EventDTO> Events { get; set; }
    }
}
