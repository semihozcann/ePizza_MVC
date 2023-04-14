using ePizza.Shared.Utilities.Results.Abstract;
using ePizza.Shared.Utilities.Results.ComplexType;
using System;

namespace ePizza.Shared.Utilities.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {


        public DataResult(ResultStatus resultStatus,T data)
        {
            ResultStatus = resultStatus;//success
            Data = data; // data list
        }
        public DataResult(ResultStatus resultStatus,string message, T data)
        {
            ResultStatus = resultStatus; //error
            Message = message; //message
            Data = data; // data null
        }
        public DataResult(T data, ResultStatus resultStatus, string message, Exception exception)
        {
            Data = data; // data null
            ResultStatus = resultStatus;// error
            Message = message; // erro message
            Exception = exception; // exception divideZero 
        }

        public T Data { get; }

        public ResultStatus ResultStatus { get; set; }

        public string Message { get; }

        public Exception Exception { get; }
    }
  

}
