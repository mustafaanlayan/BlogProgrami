using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlodProgrami.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogProgrami.Data.Concrate.EntityFramework.Context
{
   public class BlogProgramiContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=MUSTAFA\MUSTAFA,Database=Blog;Trusted_Connection=True;ConnectTimeout=30;MultipleActiveResultSets=True;");
        }
    }
}
