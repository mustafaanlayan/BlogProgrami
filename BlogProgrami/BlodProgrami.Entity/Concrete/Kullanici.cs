using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Shared.Entities.Abstract;

namespace BlodProgrami.Entity.Concrete
{
   public class Kullanici:EntityBase,IEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public byte[] SifreHash { get; set; }
        public string KullaniciAdi { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set;}
        public ICollection<Article> Articles { get; set; }

    }
}
