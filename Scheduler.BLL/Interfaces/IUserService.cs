using Scheduler.BLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scheduler.BLL.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(string login, string email);

        Task<IEnumerable<UserDTO>> GetUsers();
        Task<UserDTO> GetUserByLogin(string login);
        Task<UserDTO> GetUserByEmail(string email);
    }
}
