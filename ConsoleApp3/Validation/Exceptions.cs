using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ValidationException : Exception
    {
        public ValidationException() : base() { }
        public ValidationException(string sMessage) : base(sMessage) { }
        public ValidationException(string sMessage, Exception eExeptName) : base(sMessage, eExeptName) { }
    }
}
