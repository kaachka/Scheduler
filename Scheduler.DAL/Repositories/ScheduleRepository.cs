using Microsoft.EntityFrameworkCore;
using Scheduler.DAL.DataBase;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scheduler.DAL.Repositories
{
    public class ScheduleRepository : Repository<Schedule>, IScheduleRepository
    {
        private readonly DataBaseContext _context;

        public ScheduleRepository(DbContext context) : base(context)
        {
            _context = _context as DataBaseContext;
        }

        public async Task<IEnumerable<Event>> GetEventsByUser(int id)
        { 
            return await _context.Events
                .Include(e => e.EventTag).Include(e => e.PriorityTag)
                .Include(e => e.RepeatType).Include(e => e.Reminder)
                .Include(e => e.Owner).ToListAsync();
        }
    }
}
