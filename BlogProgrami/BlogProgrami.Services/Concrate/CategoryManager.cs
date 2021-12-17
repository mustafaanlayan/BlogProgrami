using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlodProgrami.Entity.Concrete;
using BlogProgrami.Data.Abstrach;
using BlogProgrami.Entity.Dtos;
using BlogProgrami.Services.Abstract;
using BlogProgrami.Shared.Utilities.Results.abtsracth;
using BlogProgrami.Shared.Utilities.Results.ComplexType;
using BlogProgrami.Shared.Utilities.Results.Concreate;

namespace BlogProgrami.Services.Concrate
{
   public class CategoryManager:ICategoryService
   {
       private readonly IUnitOfWork _unitOfWork;

       public CategoryManager(IUnitOfWork unitOfWork)
       {
           _unitOfWork = unitOfWork;
       }

       public async Task<IDataResult<Category>> Get(int categoryId)
       {
          var category= await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId,c=>c.Articles);
          if (category!=null)
          {
              return new DataResult<Category>(ResultStatus.Success,category);
          }

          return new DataResult<Category>(ResultStatus.Error, message: "Böyle bir Kategori Bulunamadı", data:null);
       }

        public async Task<IDataResult<IList<Category>>> GetAll()
        {
            var categories=
             await _unitOfWork.Categories.GetAllAsycn(null,c=>c.Articles);
            if (categories.Count>-1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success,categories);
            }

            return new DataResult<IList<Category>>(ResultStatus.Error,"Hiçbir Kategori Bulunamadı",data:null);
        }

        public async Task<IDataResult<IList<Category>>> GetAllNoneDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsycn(c=>!c.IsDeleted,c=>c.Articles);
            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }

            return new DataResult<IList<Category>>(ResultStatus.Error, "Hiçbir Kategori Bulunamadı", data: null);
        }

        public Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
