using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult() : base(false)
        {
        }

        public ErrorDataResult(string message) : base(false, message)
        {
        }
    }
}
