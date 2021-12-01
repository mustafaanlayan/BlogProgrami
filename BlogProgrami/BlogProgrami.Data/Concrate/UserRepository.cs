using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlodProgrami.Entity.Concrete;
using BlogProgrami.Data.Abstrach;
using BlogProgrami.Shared.Data.Concrate.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace BlogProgrami.Data.Concrate
{
   public class UserRepository:EfEntityRepostoryBase<Kullanici>,IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
