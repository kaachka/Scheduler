using System.Collections.Generic;

namespace Scheduler.DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        
        public List<Event> Events { get; set; }
        public List<Schedule> Schedules { get; set; }
    }
}