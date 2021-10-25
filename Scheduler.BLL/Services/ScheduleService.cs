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
    public class ScheduleService : IScheduleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IMapper _mapper;

        public ScheduleService(IUnitOfWork unitOfWork, IScheduleRepository scheduleRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _scheduleRepository = scheduleRepository;
            _mapper = mapper;
        }

        public async Task Add(int userId, int eventId)
        {
            await _scheduleRepository.Create(new Schedule() { EventId = eventId, UserId = userId });        
        }

        public async Task<IEnumerable<EventDTO>> GetEventsByUser(int id)
        {
            var schedule = await _scheduleRepository.GetEventsByUser(id);
            return _mapper.Map<IEnumerable<Event>, IEnumerable<EventDTO>>(schedule);
        }
    }
}
