using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Models;

namespace Scheduler.BLL.Mapping
{
    public class PriorityTagProfile : Profile
    {
        public PriorityTagProfile()
        {
            CreateMap<PriorityTag, PriorityTagDTO>().ForMember(dto => dto.Tag, map => map.MapFrom(src => src.Tag));
        }
    }
}