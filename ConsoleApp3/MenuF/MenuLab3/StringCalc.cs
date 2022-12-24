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
        public static void WriteDown(string sStr1, string sStr2)
        {
            try
            {
                if (sStr1 == sStr2)
                {
                    Console.WriteLine("They are equal");
                }
                else
                {
                    throw new Exception("They are not equal");
                }
            }
            catch(Exception eSomethingWentWrong)
            {
                Console.WriteLine(eSomethingWentWrong.Message);
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

        public static void RegexTest(string sStr)
        {
            int iCheck = 0;
            try
            {
                string sExpression = @"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+";
                if (Regex.IsMatch(sStr, sExpression, RegexOptions.IgnoreCase))
                {
                    Console.Write(sStr);
                    Console.WriteLine(" is an e-mail");
                    iCheck++;
                }
                else
                {
                    Console.Write(sStr);
                    Console.WriteLine(" is not an e-mail");
                }
                sExpression = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";
                if (Regex.IsMatch(sStr, sExpression, RegexOptions.IgnoreCase))
                {
                    Console.Write(sStr);
                    Console.WriteLine(" is a phone number");
                    iCheck++;
                }
                else
                {
                    Console.Write(sStr);
                    Console.WriteLine(" is not a phone number");
                }
                sExpression = @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}";
                if (Regex.IsMatch(sStr, sExpression, RegexOptions.IgnoreCase))
                {
                    Console.Write(sStr);
                    Console.WriteLine(" is an IP address\n");
                    iCheck++;
                }
                else
                {
                    Console.Write(sStr);
                    Console.WriteLine(" is not an IP address");
                }
                if (iCheck == 0)
                {
                    throw new Exception("It's not an e-mail, a phone number or an IP address\n\n");
                }
            }
            catch(Exception eSomethingWentWrong)
            {
                Console.Write(eSomethingWentWrong.Message);
            }
        }
    }
}
