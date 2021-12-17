using BlodProgrami.Entity.Concrete;
using BlogProgrami.Shared.Utilities.Results.abtsracth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Entity.Dtos;

namespace BlogProgrami.Services.Abstract
{
   public interface ICategoryService
   {
       Task<IDataResult<Category>> Get(int CategoryId);
       Task<IDataResult<IList<Category>>> GetAll();
       Task<IResult> Add(CategoryAddDto categoryAddDto,string createdByName);
       Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
       Task<IResult> Delete(int categoryId);
       Task<IResult> HardDelete(int categoryId);
   }
}
