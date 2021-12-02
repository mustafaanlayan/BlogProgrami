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
            builder.HasOne<Category>(a => a.Kategori).WithMany(c => c.Articles).HasForeignKey(a=>a.CategoryId);
            builder.HasOne<Kullanici>(a => a.Kullanici).WithMany(u => u.Articles).HasForeignKey(a => a.KullaniciId);
            builder.ToTable("Makaleler");
        }
    }
}
