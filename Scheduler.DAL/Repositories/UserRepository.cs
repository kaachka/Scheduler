using Microsoft.EntityFrameworkCore;
using Scheduler.DAL.DataBase;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;
using System.Threading.Tasks;

namespace Scheduler.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DataBaseContext _context;
        
        public UserRepository(DataBaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByLogin(string login)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Login == login);
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}