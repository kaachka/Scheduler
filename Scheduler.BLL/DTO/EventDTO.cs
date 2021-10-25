using System;
using System.Collections.Generic;

namespace Scheduler.BLL.DTO
{
    public class EventDTO
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public DateTime CreatedDate { get; set; }

        public ReminderDTO Reminder { get; set; }

        public RepeatTypeDTO RepeatType { get; set; }

        public PriorityTagDTO? PriorityTag { get; set; }

        public EventTagDTO? EventTag { get; set; }

        public UserDTO Owner { get; set; }
    }
}
