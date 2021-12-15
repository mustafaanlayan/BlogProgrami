using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProgrami.Shared.Utilities.Results.abtsracth
{
   public interface IDataResult<out T>:IResult
    {
        public T Data { get;}
    }
}
