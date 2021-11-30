using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Shared.Entities.Abstract;

namespace BlodProgrami.Entity.Concrete
{
  public  class Role:EntityBase,IEntity
    {
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Kullanici> Kullaniciler { get; set; }
    }
}
