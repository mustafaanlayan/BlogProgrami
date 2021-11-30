using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Shared.Data.Abstract;
using BlogProgrami.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BlogProgrami.Shared.Data.Concrate.EntityFramework
{
    
  public  class EfEntityRepostoryBase<TEntity>:IEntityRepository<TEntity> where TEntity:class,IEntity,new()
    {
        private readonly DbContext _context;

        public EfEntityRepostoryBase(DbContext context)
        {
            _context = context;
        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] inculeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (inculeProperties.Any())
            {
                foreach (var includeProperty in inculeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.SingleOrDefaultAsync();
        }

        public async Task<IList<TEntity>> GetAllAsycn(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] inculeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (predicate!=null)
            {
                query = query.Where(predicate);
            }

            if (inculeProperties.Any())
            {
                foreach (var includeProperty in inculeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.ToListAsync();
        }

        public async Task AddSycn(TEntity entity)
        {
           await _context.Set<TEntity>().AddAsync(entity);
        }

        public async Task UpdateAsycn(TEntity entity)
        {
             await Task.Run(()=>{
                _context.Set<TEntity>().Update(entity); });
        }

        public async Task DeleteAsycn(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }

        public async Task<bool> AnnyAsycn(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsycn(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }
    }
}
