using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MenuF.MenuLab3
{
    public static class StringRead
    {
        private static IDictionary<string, string> ExternalValues = null;

        public static void SetExtValues(IDictionary<string, string> values)
        {
            ExternalValues = values;
        }

        public static string Write(string paramName, string message)
        {
            if (ExternalValues == null && !string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
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
    }
}
