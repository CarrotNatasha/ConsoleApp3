using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Validation.ForDate
{
    public class IsLaterDate : ISpecification<DateTime>
    {
        private DateTime dtValue1;

        public IsLaterDate(DateTime dtValue)
        {
            dtValue1 = dtValue;
        }

        public void Validate(DateTime dtValue2)
        {
            if (dtValue1 < dtValue2)
            {
                throw new ValidationException(string.Format("Value {1:d} must be earlier than {0:d}", dtValue1, dtValue2));
            }
        }
    }
}
