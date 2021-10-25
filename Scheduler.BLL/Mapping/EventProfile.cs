using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Models;

namespace Scheduler.BLL.Mapping
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventDTO>().ForMember(dto => dto.Title, map => map.MapFrom(src => src.Title));
            CreateMap<Event, EventDTO>().ForMember(dto => dto.Description, map => map.MapFrom(src => src.Description));
            CreateMap<Event, EventDTO>().ForMember(dto => dto.Location, map => map.MapFrom(src => src.Location));
            CreateMap<Event, EventDTO>().ForMember(dto => dto.CreatedDate, map => map.MapFrom(src => src.CreatedDate));
            CreateMap<Event, EventDTO>().ForMember(dto => dto.Reminder, map => map.MapFrom(src => src.Reminder));
            CreateMap<Event, EventDTO>().ForMember(dto => dto.RepeatType, map => map.MapFrom(src => src.RepeatType));
            CreateMap<Event, EventDTO>().ForMember(dto => dto.PriorityTag, map => map.MapFrom(src => src.PriorityTag));
            CreateMap<Event, EventDTO>().ForMember(dto => dto.EventTag, map => map.MapFrom(src => src.EventTag));
        }
    }
}
