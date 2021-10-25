using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.BLL.Interfaces;
using Scheduler.DAL.DataBase;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.BLL.Services
{
    public class ReminderService : IReminderService
    {
        private readonly IReminderRepository _reminderRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReminderService(IReminderRepository reminderRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _reminderRepository = reminderRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        public async Task CreateReminder(ReminderDTO reminderDTO)
        {
            var newReminder = _mapper.Map<ReminderDTO, Reminder>(reminderDTO);
            await _reminderRepository.Create(newReminder);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<ReminderDTO>> GetReminderByEnd(DateTime end)
        {
            return _mapper.Map<IEnumerable<Reminder>, IEnumerable<ReminderDTO>>(await _reminderRepository.GetReminderByEnd(end));
        }

        public async Task<ReminderDTO> GetReminderById(int id)
        {
            return _mapper.Map<Reminder, ReminderDTO>(await _reminderRepository.Get(id));
        }

        public async Task<IEnumerable<ReminderDTO>> GetReminderByStart(DateTime start)
        {
            return _mapper.Map<IEnumerable<Reminder>, IEnumerable<ReminderDTO>>(await _reminderRepository.GetReminderByStart(start));
        }
    }
}
