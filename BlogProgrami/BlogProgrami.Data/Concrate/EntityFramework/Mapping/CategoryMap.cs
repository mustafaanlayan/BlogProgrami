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
   public class CategoryMap:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Adi).IsRequired();
            builder.Property(c => c.Adi).HasMaxLength(70);
            builder.Property(c => c.Aciklama).HasMaxLength(500);
            builder.Property(c =>c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifedByName).IsRequired();
            builder.Property(c => c.ModifedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifeDateTime).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Notlar).HasMaxLength(500);
            builder.ToTable("Categories");

            builder.HasData(
                new Category
            {
                Id = 1,
                Adi = "Csharp",
                Aciklama = "C# Programlama Dili",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifedByName = "InitialCreate",
                ModifeDateTime = DateTime.Now,
                Notlar = "C# Blok Kategorisi",
            },
            new Category
            {
                Id = 2,
                Adi = "Cplus",
                Aciklama = "C++ Programlama Dili",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifedByName = "InitialCreate",
                ModifeDateTime = DateTime.Now,
                Notlar = "C++ Blok Kategorisi",
            },
                new Category
                {
                    Id = 3,
                    Adi = "Java",
                    Aciklama = "Java Programlama Dili",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifedByName = "InitialCreate",
                    ModifeDateTime = DateTime.Now,
                    Notlar = "JavaBlok Kategorisi",
                }
                    );
        }
    }
}
