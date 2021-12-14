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
   public class UserMap:IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.KullaniciAdi).IsRequired();
            builder.Property(u => u.KullaniciAdi).HasMaxLength(20);
            builder.HasIndex(u => u.KullaniciAdi).IsUnique();
            builder.Property(u => u.SifreHash).IsRequired();
            builder.Property(u => u.SifreHash).HasColumnType("VARBINARY(500)");
            builder.Property(u => u.Aciklama).HasMaxLength(500);
            builder.Property(u => u.Adi).IsRequired();
            builder.Property(u => u.Adi).HasMaxLength(30);
            builder.Property(u => u.Soyadi).IsRequired();
            builder.Property(u => u.Soyadi).HasMaxLength(30);
            builder.Property(u => u.Resim).IsRequired();
            builder.Property(u => u.Resim).HasMaxLength(250);
            builder.HasOne<Role>(u => u.Role).WithMany(r=>r.Kullaniciler).HasForeignKey(u=>u.RoleId);
            builder.Property(u => u.CreatedByName).IsRequired();
            builder.Property(u => u.CreatedByName).HasMaxLength(50);
            builder.Property(u => u.ModifedByName).IsRequired();
            builder.Property(u => u.ModifedByName).HasMaxLength(50);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.ModifeDateTime).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.Property(u => u.Notlar).HasMaxLength(500);
            builder.ToTable("Kullaniciler");

            builder.HasData(new Kullanici
            {
                Id = 1,
                RoleId = 1,
                Adi = "Mustafa",
                Soyadi = "ANLAYAN",
                KullaniciAdi = "mustafaanlayan",
                Email = "mustafaanlayan@tgmail.com",
                Resim = "Defaultİmage",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifedByName = "InitialCreate",
                ModifeDateTime = DateTime.Now,
                Aciklama = "ilk Admin Kullanıcısı",
                Notlar = "Admin Kullanıcısı",
                SifreHash =Encoding.ASCII.GetBytes("0192023a7bbd73250516f069df18b500")
            });

        }
    }
}
