using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Models;

namespace Scheduler.BLL.Mapping
{
    public class PriorityTagProfile : Profile
    {
        public PriorityTagProfile()
        {
            CreateMap<PriorityTag, PriorityTagDTO>().ReverseMap();
        }
    }
}
