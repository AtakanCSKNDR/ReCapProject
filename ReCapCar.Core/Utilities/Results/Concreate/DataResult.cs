using ReCapCar.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.Core.Utilities.Results.Concreate
{
    public class DataResult<T> : Result , IDataResult<T>
    {
        public DataResult(T data , bool success , string message):base(success, message)
        {
            Data = data;
        }
        public DataResult(T data , bool success):base(success) 
        {
            Data = data;
        }
        public T Data { get; }
    }
}
