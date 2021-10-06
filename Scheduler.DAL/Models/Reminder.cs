using System;
using System.Collections.Generic;

namespace Scheduler.DAL.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public DateTime StartRemind { get; set; }
        public DateTime EndRemind { get; set; }
        
        public List<Event> Events { get; set; }
    }
}