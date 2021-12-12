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
  public  class ArticleMap:IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Baslik).HasMaxLength(100);
            builder.Property(a => a.Baslik).IsRequired(true);
            builder.Property(a => a.Icerik).IsRequired();
            builder.Property(a => a.Icerik).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.SeoAciklama).IsRequired();
            builder.Property(a => a.SeoAciklama).HasMaxLength(50);
            builder.Property(a => a.Etiket).IsRequired();
            builder.Property(a => a.Etiket).HasMaxLength(70);
            builder.Property(a => a.OkunmaSayisi).IsRequired();
            builder.Property(a => a.YorumSayisi).IsRequired();
            builder.Property(a => a.Resim).IsRequired();
            builder.Property(a => a.Resim).HasMaxLength(250);
            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifedByName).IsRequired();
            builder.Property(a => a.ModifedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifeDateTime).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Notlar).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Kategori).WithMany(a => a.Articles).HasForeignKey(c=>c.CategoryId);
            builder.HasOne<Kullanici>(a => a.Kullanici).WithMany(u => u.Articles).HasForeignKey(a => a.KullaniciId);
            builder.ToTable("Makaleler");

            builder.HasData(new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Baslik = "C# 9.0",
                    Icerik = "gdeggwhhwhwhewhwhwhwhhwhjwhwehhwehwehwehhwehwhwhh",
                    Resim = "Default.jpeg",
                    SeoAciklama = "C# 9.0",
                    MetaTag = "C#,C#9",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifedByName = "InitialCreate",
                    ModifeDateTime = DateTime.Now,
                    Notlar = "JavaBlok Kategorisi",
                    KullaniciId = 1,
                    YorumSayisi = 1,
                    OkunmaSayisi = 100,
                    Etiket = "C#"
                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    Baslik = "C# 9.0",
                    Icerik = "gdeggwhhwhwhewhwhwhwhhwhjwhwehhwehwehwehhwehwhwhh",
                    Resim = "Default.jpeg",
                    SeoAciklama = "C# 9.0",
                    MetaTag = "C#,C#9",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifedByName = "InitialCreate",
                    ModifeDateTime = DateTime.Now,
                    Notlar = "JavaBlok Kategorisi",
                    KullaniciId = 1,
                    YorumSayisi = 1,
                    OkunmaSayisi = 100,
                    Etiket = "c#"
                }
            );
        }
    }
}
