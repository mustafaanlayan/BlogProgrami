using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlodProgrami.Entity.Concrete;
using BlogProgrami.Shared.Data.Abstract;

namespace BlogProgrami.Data.Abstrach
{
  public  interface ICategoryRepository:IEntityRepository<Category>
    {
    }
}
