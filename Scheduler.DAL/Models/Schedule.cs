namespace Scheduler.DAL.Models
{
    public class Schedule
    {
        public User User { get; set; }
        public int UserId { get; set; }
        
        public Event Event { get; set; }
        public int EventId { get; set; }
    }
}