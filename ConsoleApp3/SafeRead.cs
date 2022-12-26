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
        private static string GetValue(string paramName, string message)
        {
            string sValue = null;
            if (ExternalValues == null)
            {
                sValue = Console.ReadLine();
            }
            else
            {
                if (!ExternalValues.TryGetValue(paramName, out sValue))
                {
                    throw new InvalidOperationException(string.Format("Parameter -{0} not specify.", paramName));
                }
            }
            return sValue;
        }

        private static IDictionary<string, string> ExternalValues = null;

        public static void SetExtValues(IDictionary<string, string> values)
        {
            ExternalValues = values;
        }

        public static int SafeReadInt(string paramName, string message, ISpecification<int> Specification = null)
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            while (true)
            {
                string sValue = GetValue(paramName, message);

                try
                {
                    int iValue = Int32.Parse(sValue);
                    if (Specification != null)
                    {
                        Specification.Validate(iValue);
                    }
                    return iValue;
                }
                catch (Exception eIntExcept)
                {
                    if ((eIntExcept is ValidationException) ||
                        (eIntExcept is FormatException) ||
                        (eIntExcept is OverflowException))
                    {
                        Console.WriteLine("ERROR: " + eIntExcept.Message);
                        if (ExternalValues != null)
                        {
                            throw new InvalidOperationException(eIntExcept.Message);
                        }
                    }
                    throw eIntExcept;
                }
            }
        }

        public static DateTime SafeDate(string paramName, string message, ISpecification<DateTime> Specification = null)
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }

            while (true)
            {
                string sValue = GetValue(paramName, message);
                try {
                    DateTime dtDate = DateTime.ParseExact(sValue, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                    if (Specification != null)
                    {
                        Specification.Validate(dtDate);
                    }
                    return dtDate;
                }
                catch (FormatException eDateException)
                {
                    Console.WriteLine("ERROR: " + eDateException.Message);
                    if (ExternalValues != null)
                    {
                        throw new InvalidOperationException(eDateException.Message);
                    }
                }
            }
        }
    }
}


