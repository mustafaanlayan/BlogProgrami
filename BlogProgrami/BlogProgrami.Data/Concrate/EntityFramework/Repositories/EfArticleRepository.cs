using BlodProgrami.Entity.Concrete;
using BlogProgrami.Data.Abstrach;
using BlogProgrami.Shared.Data.Concrate.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BlogProgrami.Data.Concrate.EntityFramework.Repositories
{
   public class EfArticleRepository:EfEntityRepostoryBase<Article>,IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
        }
    }
}
