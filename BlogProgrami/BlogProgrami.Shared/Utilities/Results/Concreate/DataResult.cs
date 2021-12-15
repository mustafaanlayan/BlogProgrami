﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProgrami.Shared.Utilities.Results.abtsracth;
using BlogProgrami.Shared.Utilities.Results.ComplexType;

namespace BlogProgrami.Shared.Utilities.Results.Concreate
{
   public class DataResult<T>:IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus,T data)
        {
            ResultStatus = resultStatus;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, string message, T data)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, string message, T data,Exception exception)
        {
            ResultStatus = resultStatus;
            Message = message;
            Data = data;
            Exceptione = exception;
        }

        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exceptione { get; }
        public T Data { get; }
    }
}
