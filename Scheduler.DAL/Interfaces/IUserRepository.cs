using Scheduler.DAL.Models;
using System.Threading.Tasks;

namespace Scheduler.DAL.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByLogin(string login);
        Task<User> GetByEmail(string email);
    }
}