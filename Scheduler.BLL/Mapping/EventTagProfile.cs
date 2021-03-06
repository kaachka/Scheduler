using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Models;

namespace Scheduler.BLL.Mapping
{
    public class EventTagProfile : Profile
    {
        public EventTagProfile()
        {
            CreateMap<EventTag, EventTagDTO>().ForMember(dto => dto.Tag, map => map.MapFrom(src => src.Tag));
        }
    }
}
