using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Data.Abstrach;
using BlogProgrami.Data.Concrate.EntityFramework.Context;
using BlogProgrami.Data.Concrate.EntityFramework.Repositories;

namespace BlogProgrami.Data.Concrate
{
  public  class UnitOfWork:IUnitOfWork
  {
      private readonly BlogProgramiContext _context;
      private EfArticleRepository _articleRepository;
      private EfCategoryRepository _categoryRepository;
      private EfCommentRepository _commentRepository;
      private EfRoleRepository _roleRepository;
      private EfUserRepository _userRepository;

      public UnitOfWork(BlogProgramiContext context)
      {
          _context = context;
      }

     

      public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);
      public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);
      public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);
      public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);
      public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async Task<int> SaveAsycn()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
  }
}
