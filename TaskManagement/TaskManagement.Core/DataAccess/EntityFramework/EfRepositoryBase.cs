using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Entities;

namespace TaskManagement.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : EfRepositoryBase<TEntity, int, TContext>
        where TEntity : class, IEntity<int>, new()
        where TContext : DbContext, new()
    {
        public EfRepositoryBase(TContext context) : base(context) { }
    }
    public class EfRepositoryBase<TEntity, TKey, TContext> : IRepository<TEntity, TKey>, IDisposable
    where TEntity : class, IEntity<TKey>, new()
    where TContext : DbContext, new()
    {
        protected readonly TContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        public EfRepositoryBase(TContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(TKey key)
        {
            return await _dbSet.FindAsync(key);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            if (entity.IsActive != null)
            {
                TEntity tEntity = entity;
                tEntity.IsActive = false;

                await UpdateAsync(tEntity);
            }
            else
            {
                var entry = _context.Entry(entity);
                _dbSet.Attach(entity);
                entry.State = EntityState.Deleted;

                await _context.SaveChangesAsync();
            }
        }

        public async Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync(predicate);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        #region Dispose
        private bool _disposed = false;
        public void Dispose() => Dispose(true);

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _context.Dispose();
            }

            _disposed = true;
        }
        #endregion
    }
}
