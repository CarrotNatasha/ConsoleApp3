using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ЛАБА 1, В9.  Z/X + 7*sqrt(Y)
//ЛАБА 2, В2. Функция Аккермана (m - длина отрезка пересечения дат, n = 5);
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            SafeRead.SetExtValues(ArgsParser.Parse(args));

            Menu.Clear();
            Menu.AddItem(new MenuF.MenuExit());
            Menu.AddItem(new MenuF.MenuHelloWorld());
            Menu.AddItem(new MenuF.MenuLab1Calc());
            Menu.AddItem(new MenuF.MenuLab2RecursionDate());
            Menu.AddItem(new MenuF.MenuLab3String());
            while (true)
            {
                Console.Clear();
                Menu.Execute();
                Console.ReadLine();
            }
        }
    }
}
