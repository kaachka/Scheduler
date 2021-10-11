using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.BLL.Interfaces;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.Services
{
    class EventService : IEventService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventService(IUnitOfWork unitOfWork, IEventRepository eventRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EventDTO>> GetEvents(DateTime dateTime)
        {
            return _mapper.Map<IEnumerable<Event>, IEnumerable<EventDTO>>(await _eventRepository.GetEventsByDate(dateTime));
        }
    }
}
