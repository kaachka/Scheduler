using System;
using System.Threading.Tasks;
using Scheduler.DAL.DataBase;
using Scheduler.DAL.Interfaces;

namespace Scheduler.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DataBaseContext _context;

        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}