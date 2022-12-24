using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MenuF
{
    public class MenuLab2RecursionDate : MenuCore
    {
        public override string Title { get { return "Recursion Date"; } }

        public override void Execute()
        {
            uint uiM = 0;
            uint uiN = 5;
            Console.WriteLine("Date format is (DD.MM.YYYY)\nMax - 62 days");
            DateTime dtRecDateStart1, dtRecDateEnd1, dtRecDateStart2, dtRecDateEnd2;
            do
            {
                Console.WriteLine("Write down start of the first date");
                dtRecDateStart1 = SafeRead.SafeDate(null,null);
                Console.WriteLine("Write down end of the first date");
                dtRecDateEnd1 = SafeRead.SafeDate(null,null);
                if (dtRecDateEnd1 < dtRecDateStart1)
                {
                    Console.WriteLine("ERROR: You can't timetravel. Try again");
                }
            } while (dtRecDateEnd1 < dtRecDateStart1);
            do
            {
                Console.WriteLine("Write down start of the second date");
                dtRecDateStart2 = SafeRead.SafeDate(null,null);
                Console.WriteLine("Write down end of the second date");
                dtRecDateEnd2 = SafeRead.SafeDate(null,null);
                if (dtRecDateEnd2 < dtRecDateStart2)
                {
                    Console.WriteLine("ERROR: You can't timetravel. Try again");
                }
            } while (dtRecDateEnd2 < dtRecDateStart2);
            uiM = RecursionDate.RecursionCalc.DateWriteiM(dtRecDateStart1, dtRecDateEnd1, dtRecDateStart2, dtRecDateEnd2);
            Console.Write("The result: ");
            Console.WriteLine(RecursionDate.RecursionCalc.RecursionAkermann(uiM, uiN));
        }
    }
}
