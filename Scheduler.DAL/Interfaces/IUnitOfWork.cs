using System.Threading.Tasks;

namespace Scheduler.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        int Save();
        Task<int> SaveAsync();
    }
}