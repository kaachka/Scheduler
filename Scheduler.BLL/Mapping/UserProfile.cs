using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Models;

namespace Scheduler.BLL.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ForMember(dto => dto.Login, map => map.MapFrom(src => src.Login));
            CreateMap<User, UserDTO>().ForMember(dto => dto.Email, map => map.MapFrom(src => src.Email));
        }
    }
}
