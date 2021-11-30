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
    private readonly DbContext _context;
     
    
  public  class EfEntityRepostoryBase<TEntity>:IEntityRepository<TEntity> where TEntity:class,IEntity,new()
    {
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] inculeProperties)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<TEntity>> GetAllAsycn(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] inculeProperties)
        {
            throw new NotImplementedException();
        }

        public async Task AddSycn(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsycn(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsycn(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AnnyAsycn(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CountAsycn(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
