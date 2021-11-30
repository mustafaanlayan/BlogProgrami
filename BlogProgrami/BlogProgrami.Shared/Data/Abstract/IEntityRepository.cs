using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Shared.Entities.Abstract;

namespace BlogProgrami.Shared.Data.Abstract
{
   public interface IEntityRepository<T> where T:class,IEntity,new()
   {
       Task<T> GetAsync(Expression<Func<T,bool>>predicate,params Expression<Func<T,object>>[]inculeProperties);

       Task<IList<T>> GetAllAsycn(Expression<Func<T, bool>> predicate = null,
           params Expression<Func<T, object>>[] inculeProperties);

       Task AddSycn(T entity);
       Task UpdateAsycn(T entity);
       Task DeleteAsycn(T entity);
       Task<bool> AnnyAsycn(Expression<Func<T, bool>> predicate);
       Task<int> CountAsycn(Expression<Func<T, bool>> predicate);

   }
}
