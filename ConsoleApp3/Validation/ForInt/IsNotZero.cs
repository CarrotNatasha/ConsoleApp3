using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Validation
{
    public class IsNotZero : ISpecification<int>
    {
        public void Validate(int iValue)
        {
            if (iValue == 0)
            {
                throw new ValidationException(string.Format("Value {0} must not be zero", iValue));
            }
        }
    }
}
