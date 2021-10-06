using Microsoft.EntityFrameworkCore;
using Scheduler.DAL.DataBase;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;

namespace Scheduler.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DataBaseContext _context;
        
        public UserRepository(DbContext context) : base(context)
        {
            _context = Context as DataBaseContext;
        }
    }
}