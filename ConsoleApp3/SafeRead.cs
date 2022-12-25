using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Validation;

namespace ConsoleApp3
{
    public static class SafeRead
    {
        public static int SafeReadInt(string message, ISpecification<int> Specification = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue))
                {
                    try
                    {
                        if (Specification != null)
                        {
                            Specification.Validate(iValue);
                        }
                        return iValue;
                    }
                    catch(ValidationException eIntExcept)
                    {
                        Console.WriteLine("ERROR: " + eIntExcept.Message);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Impossible number. Try Again\n");
                }
                
            }
        }
        public static DateTime SafeDate(string message, ISpecification<DateTime> Specification = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                DateTime dtDate;
                if (DateTime.TryParseExact(sValue, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dtDate))
                {
                    try
                    {
                        if (Specification != null)
                        {
                            Specification.Validate(dtDate);
                        }
                        return dtDate;
                    }
                    catch (ValidationException eDateTimeExcept)
                    {
                        Console.WriteLine("ERROR: " + eDateTimeExcept.Message);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Impossible date. Try again\n");
                }
            }
        }
    }
}
