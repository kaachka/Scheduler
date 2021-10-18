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

        public async Task<IEnumerable<ScheduleDTO>> GetEventsByUser(int id)
        {
            return _mapper.Map<IEnumerable<Schedule>, IEnumerable<ScheduleDTO>>(await _scheduleRepository.GetEventsByUser(id));
        }
    }
}
