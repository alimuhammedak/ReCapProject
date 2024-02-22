using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool isSuccess) : base(isSuccess)
        {

        }

        public DataResult(T data, bool isSuccess, string message) : base(isSuccess, message)
        {
        }

        public T Data { get; }
    }
}
