using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Shared.Entities.Abstract;

namespace BlodProgrami.Entity.Concrete
{
  public  class Article:EntityBase,IEntity
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
        public DateTime Date { get; set; }
        public int OkunmaSayisi { get; set; }
        public int YorumSayisi { get; set; }
        public string MetaTag { get; set; }
        public string SeoAciklama { get; set; }
        public string Etiket { get; set; }
        public int CategoryId { get; set; }
        public Category Kategori { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
