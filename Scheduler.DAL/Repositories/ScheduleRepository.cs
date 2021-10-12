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
            _context = Context as DataBaseContext;
        }

        public async Task<IEnumerable<Schedule>> GetEventsByUser(int id)
        {
            var events = (from schedule in _context.Schedules.Include(s => s.Event)
                          where schedule.UserId == id
                          select schedule).ToListAsync();

            return await events;
        }
    }
}
