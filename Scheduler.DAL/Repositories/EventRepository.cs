using Microsoft.EntityFrameworkCore;
using Scheduler.DAL.DataBase;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler.DAL.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private readonly DataBaseContext _context;

        public EventRepository(DbContext context) : base(context)
        {
            _context = Context as DataBaseContext;
        }

        public async Task<IEnumerable<Event>> GetEventsByDate(DateTime date)
        {
            return await _context.Events.Include(d => d.Reminder).Where(d => d.Reminder.EndRemind == date).ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetEventsByProirity(int priorityId)
        {
            return await FindAll(p => p.PriorityTagId == priorityId);
        }

        public async Task<IEnumerable<Event>> GetEventsByTag(int tagId)
        {
            return await FindAll(p => p.EventTagId == tagId);
        }
    }
}
