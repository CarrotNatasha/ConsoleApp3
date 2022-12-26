using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp3.MenuF
{
    class MenuLab3String : MenuCore
    {
        public override string Title { get { return "String"; } }

        public override void Execute()
        {
            string sStr1, sStr2;

            Console.WriteLine("Write down first sentence");
            sStr1 = MenuLab3.StringRead.Write("str1","");
            Console.WriteLine("Write down second sentence");
            sStr2 = MenuLab3.StringRead.Write("str2","");

            Console.WriteLine("\nFirst test:");
            MenuLab3.StringCalc.WriteDown(sStr1, sStr2);

            Console.WriteLine("\nSecond test:");
            string sCheck1 = MenuLab3.StringCalc.Beautifying(sStr1);
            string sCheck2 = MenuLab3.StringCalc.Beautifying(sStr2);
            MenuLab3.StringCalc.WriteDown(sCheck1, sCheck2);

            Console.WriteLine("\nThird test:");
            sCheck1 = MenuLab3.StringCalc.ReverseStr(sStr1);
            MenuLab3.StringCalc.WriteDown(sCheck1, sStr2);

            Console.WriteLine("\nFourth test:");
            MenuLab3.StringCalc.RegexTest(sStr1);
            MenuLab3.StringCalc.RegexTest(sStr2);
        }
    }
}
