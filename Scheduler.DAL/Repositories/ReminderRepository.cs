using Microsoft.EntityFrameworkCore;
using Scheduler.DAL.DataBase;
using Scheduler.DAL.Interfaces;
using Scheduler.DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scheduler.DAL.Repositories
{
    public class ReminderRepository : Repository<Reminder>, IReminderRepository
    {
        private readonly DataBaseContext _context;
        
        public ReminderRepository(DataBaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reminder>> GetReminderByEnd(DateTime end)
        {
            return await FindAll(r => r.EndRemind == end);
        }

        public async Task<IEnumerable<Reminder>> GetReminderByStart(DateTime start)
        {
            return await FindAll(r => r.StartRemind == start);
        }
    }
}
