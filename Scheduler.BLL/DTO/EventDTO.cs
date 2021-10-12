using System;
using System.Collections.Generic;

namespace Scheduler.BLL.DTO
{
    public class EventDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }

        public ReminderDTO Reminder { get; set; }
        public int ReminderId { get; set; }

        public RepeatTypeDTO RepeatType { get; set; }
        public int RepeatTypeId { get; set; }

        public PriorityTagDTO PriorityTag { get; set; }
        public int PriorityTagId { get; set; }

        public EventTagDTO EventTag { get; set; }
        public int EventTagId { get; set; }

        public UserDTO Owner { get; set; }
        public int OwnerId { get; set; }
    }
}
