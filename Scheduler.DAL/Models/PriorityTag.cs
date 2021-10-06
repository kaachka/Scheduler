using System.Collections.Generic;

namespace Scheduler.DAL.Models
{
    public class PriorityTag
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        
        public List<Event> Events { get; set; }
    }
}