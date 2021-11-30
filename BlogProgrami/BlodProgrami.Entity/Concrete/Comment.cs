using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Shared.Entities.Abstract;

namespace BlodProgrami.Entity.Concrete
{
   public class Comment:EntityBase,IEntity
    {
        public string Yazi { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
