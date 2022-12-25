using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Validation
{
    public class IsEarlierDate : ISpecification<DateTime>
    {
        private DateTime dtValue1;

        public IsEarlierDate(DateTime dtValue)
        {
            dtValue1 = dtValue;
        }

        public void Validate(DateTime dtValue2)
        {
            if (dtValue1 > dtValue2)
            {
                throw new ValidationException(string.Format("Value {0:d} must be earlier than {1:d}", dtValue1, dtValue2));
            }
        }
    }
}
