using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Scheduler.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        Task<TEntity> Get(int id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> FindAll(Expression<Func<TEntity, bool>> predicate);
    }
}