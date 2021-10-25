using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Models;

namespace Scheduler.BLL.Mapping
{
    public class ReminderProfile : Profile
    {
        public ReminderProfile()
        {
            CreateMap<Reminder, ReminderDTO>().ForMember(dto => dto.StartRemind, map => map.MapFrom(src => src.StartRemind))
                .ForMember(dto => dto.EndRemind, map => map.MapFrom(src => src.EndRemind)).ReverseMap();
        }
    }
}

