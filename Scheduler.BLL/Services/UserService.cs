using AutoMapper;
using Scheduler.BLL.DTO;
using Scheduler.BLL.Interfaces;
using Scheduler.DAL.DataBase;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scheduler.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly DataBaseContext context;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork, IMapper mapper, DataBaseContext context)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            this.context = context;
        }

        public async Task CreateUser(string login, string email)
        {
            //if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(email))
            //    return;
            var user = new User() {Login = login, Email = email};
            await _userRepository.Create(user);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            return _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(await _userRepository.GetAll());      
        }
    }
}
