using BlodProgrami.Entity.Concrete;
using BlogProgrami.Data.Abstrach;
using BlogProgrami.Shared.Data.Concrate.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BlogProgrami.Data.Concrate.EntityFramework.Repositories
{
   public class EfUserRepository:EfEntityRepostoryBase<Kullanici>,IUserRepository
    {
        public EfUserRepository(DbContext context) : base(context)
        {
        }
    }
}
