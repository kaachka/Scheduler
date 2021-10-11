using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.Mapping
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventDTO>().ForMember(dto => dto.EventTag, map => map.MapFrom(source => new EventTag
            {
                Id = source.Id,
                Tag = source.EventTag.ToString()
            }));

            
        }
    }
}
