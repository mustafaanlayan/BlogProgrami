using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Shared.Utilities.Results.ComplexType;

namespace BlogProgrami.Shared.Utilities.Results.abtsracth
{
   public interface IResult
    {
        public ResultStatus ResultStatus { get;  }
        public string Message { get;  }
        public Exception Exceptione { get;  }

    }
}
