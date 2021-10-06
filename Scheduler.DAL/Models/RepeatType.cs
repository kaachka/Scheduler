using System.Collections.Generic;

namespace Scheduler.DAL.Models
{
    public class RepeatType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        
        public List<Event> Events { get; set; }
    }
}