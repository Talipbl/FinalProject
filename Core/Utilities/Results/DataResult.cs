using Core.Utilities.Results.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string messages) : base(success, messages)
        {
            Data = data;
        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public DataResult(bool success, string message) : base(success, message)
        {

        }
        public DataResult() : base(default)
        {

        }
        public T Data { get; }
    }
}
