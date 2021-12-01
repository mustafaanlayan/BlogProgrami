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
   public class RoleRepository:EfEntityRepostoryBase<Role>,IRoleRepository
    {
        public RoleRepository(DbContext context) : base(context)
        {
        }
    }
}
