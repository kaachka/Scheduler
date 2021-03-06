using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Models;

namespace Scheduler.BLL.Mapping
{
    public class RepeatTypeProfile : Profile
    {
        public RepeatTypeProfile()
        {
            CreateMap<RepeatType, RepeatTypeDTO>().ForMember(dto => dto.Type, map => map.MapFrom(src => src.Type));
        }
    }
}
