using System;
using System.Collections.Generic;

namespace Scheduler.DAL.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public Reminder? Reminder { get; set; }
        public int? ReminderId { get; set; }
        
        public RepeatType RepeatType { get; set; }
        public int RepeatTypeId { get; set; }
        
        public PriorityTag? PriorityTag { get; set; }
        public int? PriorityTagId { get; set; }
        
        public EventTag? EventTag { get; set; }
        public int? EventTagId { get; set; }
        
        public User Owner { get; set; }
        public int OwnerId { get; set; }
        
        public List<Schedule> Schedules { get; set; }
    }
}