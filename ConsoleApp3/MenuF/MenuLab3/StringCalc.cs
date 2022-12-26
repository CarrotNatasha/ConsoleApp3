using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp3.MenuF.MenuLab3
{
    public static class StringCalc
    {
        public static int WriteDown(string sStr1, string sStr2)
        {
            try
            {
                int iCheck = 0;
                if (sStr1 == sStr2)
                {
                    Console.WriteLine("They are equal");
                    iCheck++;
                }
                else
                {
                    throw new Exception("They are not equal");
                }
                return iCheck;
            }
            catch(Exception eSomethingWentWrong)
            {
                Console.WriteLine(eSomethingWentWrong.Message);
                return 0;
            }
        }

        public static string Beautifying(string sStr)
        {
            sStr = sStr.ToLower();
            sStr = sStr.Trim();
            while (sStr.Contains("  "))
            {
                sStr = sStr.Replace("  ", " ");
            }
            return sStr;
        }

        public static string ReverseStr(string sStr)
        {
            char[] aArrStr = sStr.ToCharArray();
            Array.Reverse(aArrStr);
            sStr = String.Join("", aArrStr);
            return sStr;
        }

        public static int RegexTest(string sStr)
        {
            try
            {
                int iCheck = 0;
                string sExpression = @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+";
                if (Regex.IsMatch(sStr, sExpression, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("{0} is an e-mail", sStr);
                    iCheck++;
                }
                sExpression = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";
                if (Regex.IsMatch(sStr, sExpression, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("{0} is a phone number", sStr);
                    iCheck++;
                }
                sExpression = @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
                if (Regex.IsMatch(sStr, sExpression, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("{0} is an IP address\n", sStr);
                    iCheck++;
                }
                if (iCheck == 0)
                {
                    throw new Exception("It's not an e-mail, a phone number or an IP address\n\n");
                }
                return iCheck;
            }
            catch(Exception eSomethingWentWrong)
            {
                Console.Write(eSomethingWentWrong.Message);
                return 0;
            }
        }
    }
}
