using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgrami.Shared.Entities.Abstract
{
   public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreatedTime { get; set; }=DateTime.Now;
        public virtual DateTime ModifeDateTime { get; set; }=DateTime.Now;
        public virtual bool IsDeleted { get; set; } = false;
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; } = "Admin";
        public virtual string ModifedByName { get; set; } = "Admin";
        public virtual string Notlar { get; set; }
    }
}
