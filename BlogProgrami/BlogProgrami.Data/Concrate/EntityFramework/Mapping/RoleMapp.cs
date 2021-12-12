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
   public class RoleMapp:IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Adi).IsRequired();
            builder.Property(r => r.Adi).HasMaxLength(30);
            builder.Property(r => r.Aciklama).IsRequired();
            builder.Property(r => r.Aciklama).HasMaxLength(250);
            builder.Property(r => r.CreatedByName).IsRequired();
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.ModifedByName).IsRequired();
            builder.Property(r => r.ModifedByName).HasMaxLength(50);
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.ModifeDateTime).IsRequired();
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.Notlar).HasMaxLength(500);
            builder.ToTable("Roller");
            builder.HasData(new Role
            {

                Id = 1,
                Adi = "Admin",
                Aciklama = "Admin Rolü Tüm Haklara Sahiptir",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifedByName = "InitialCreate",
                ModifeDateTime = DateTime.Now,
                Notlar = "Admin Rolüdür"
            });
        }
    }
}
