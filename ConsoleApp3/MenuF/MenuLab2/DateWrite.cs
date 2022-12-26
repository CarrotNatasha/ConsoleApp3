using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Validation;
using ConsoleApp3.Validation.ForDate;

namespace ConsoleApp3.MenuF
{
    public class MenuLab2RecursionDate : MenuCore
    {
        public override string Title { get { return "Recursion Date"; } }

        public override void Execute()
        {
            uint uiM = 0;
            uint uiN = 5;
            Console.WriteLine("Date format is (DD.MM.YYYY)\nMax - 62 days\nEarlier timespan goes first");
            DateTime dtRecDateStart1, dtRecDateEnd1, dtRecDateStart2, dtRecDateEnd2;
            Console.WriteLine("Write down start of the first date");
            dtRecDateStart1 = MenuLab2.DateRead.Write();
            Console.WriteLine("Write down end of the first date");
            dtRecDateEnd1 = MenuLab2.DateRead.WriteEarlier(dtRecDateStart1);
            Console.WriteLine("Write down start of the second date");
            dtRecDateStart2 = MenuLab2.DateRead.WriteLater(dtRecDateEnd1);
            Console.WriteLine("Write down end of the second date");
            dtRecDateEnd2 = MenuLab2.DateRead.WriteEarlier(dtRecDateStart2);
            uiM = MenuLab2.DateCalc.DateWriteiM(dtRecDateStart1, dtRecDateEnd1, dtRecDateStart2, dtRecDateEnd2);
            Console.Write("The result: ");
            Console.WriteLine(MenuLab2.DateCalc.RecursionAkermann(uiM, uiN));
        }
    }
}
