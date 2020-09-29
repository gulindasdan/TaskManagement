using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Entities;

namespace TaskManagement.Core.DataAccess
{
    public interface IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>, new()
    {

        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey key);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity,bool>> predicate);
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity,bool>> predicate);
        TEntity Get(TEntity entity);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task Update(TEntity entity);
        Task Remove(TEntity entity);
        Task RemoveRange(IEnumerable<TEntity> entities);

    }
}
