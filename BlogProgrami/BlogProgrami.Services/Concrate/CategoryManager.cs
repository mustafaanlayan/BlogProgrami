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

        public async Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            await _unitOfWork.Categories.AddAsycn(new Category
            {
                Adi = categoryAddDto.Name,
                Aciklama = categoryAddDto.Description,
                Notlar = categoryAddDto.Notes,
                IsActive = categoryAddDto.IsActive,
                CreatedByName = createdByName,
                CreatedDate = DateTime.Now,
                ModifedByName = createdByName,
                ModifeDateTime = DateTime.Now,
                IsDeleted = false
            }).ContinueWith(t=>_unitOfWork.SaveAsycn());
           // await _unitOfWork.SaveAsycn();
            return new Result(ResultStatus.Success, $"{categoryAddDto.Name} adlı Kategori Başarıyla Eklenmiştir");
        }

        public async Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryUpdateDto.Id);
            if (category!=null)
            {
                category.Adi = categoryUpdateDto.Name;
                category.Aciklama = categoryUpdateDto.Description;
                category.Notlar = categoryUpdateDto.Notes;
                category.IsActive = categoryUpdateDto.IsActive;
                category.IsDeleted = categoryUpdateDto.IsDeleted;
                category.ModifedByName = modifiedByName;
                category.ModifeDateTime=DateTime.Now;
                await _unitOfWork.Categories.UpdateAsycn(category).ContinueWith(t=>_unitOfWork.SaveAsycn());
                return new Result(ResultStatus.Success, $"{categoryUpdateDto.Name} adlı Kategori Başarıyla Güncellendi");
            }
            return new Result(ResultStatus.Error, "Hiçbir Kategori Bulunamadı");
        }

        public async Task<IResult> Delete(int categoryId, string modifiedByName)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category!=null)
            {
                category.IsDeleted = true;
                category.ModifedByName = modifiedByName;
                category.ModifeDateTime=DateTime.Now;
                await _unitOfWork.Categories.UpdateAsycn(category).ContinueWith(t=>_unitOfWork.SaveAsycn());
                return new Result(ResultStatus.Success, $"{category.Adi} adlı Kategori Başarıyla Silinmiştir");
            }
            return new Result(ResultStatus.Error, "Hiçbir Kategori Bulunamadı");
        }

        public async Task<IResult> HardDelete(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId);
            if (category != null)
            {
                await _unitOfWork.Categories.DeleteAsycn(category).ContinueWith(t => _unitOfWork.SaveAsycn());
                return new Result(ResultStatus.Success, $"{category.Adi} adlı Kategori Başarıyla Veritabanından Silinmiştir");
            }
            return new Result(ResultStatus.Error, "Hiçbir Kategori Bulunamadı");
        }
    }
}
