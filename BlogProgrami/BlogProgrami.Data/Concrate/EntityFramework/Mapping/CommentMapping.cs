using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlodProgrami.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProgrami.Data.Concrate.EntityFramework.Mapping
{
   public class CommentMapping:IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Yazi).IsRequired();
            builder.Property(c => c.Yazi).HasMaxLength(3000);
            builder.HasOne<Article>(c => c.Article).WithMany(a=>a.Comments).HasForeignKey(c=>c.ArticleId);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifedByName).IsRequired();
            builder.Property(c => c.ModifedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifeDateTime).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Notlar).HasMaxLength(500);
            builder.ToTable("Yorumlar");

            builder.HasData(new Comment
            {
                Id = 1,
                ArticleId = 1,
                Yazi = "hhushshaıusıusahsusjhjsakjsajsjskj",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifedByName = "InitialCreate",
                ModifeDateTime = DateTime.Now,
                Notlar = "JavaBlok Kategorisi"
            });

        }
    }
}
