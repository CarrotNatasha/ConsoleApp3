using ConsoleApp3.MenuF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Menu
    {
        private static List<MenuCore> MenuF = new List<MenuCore>();

        public static void Clear()
        {
            Menu.MenuF.Clear();
        }

        public static void AddItem(MenuCore menuF)
        {
            Menu.MenuF.Add(menuF);
        }

        public static void Execute()
        {
            ShowMenu();
            int iMenu = SafeRead.SafeReadInt(null,null);
            if (iMenu >= 0 && iMenu < Menu.MenuF.Count)
            {
                Menu.MenuF.ToArray()[iMenu].Execute();
            }
            else
            {
                Console.WriteLine("Wrong number! Please, try again");
            }
        }
        private static void ShowMenu()
        {
            Console.WriteLine("==========MAIN MENU==========");

            int iMenuItem = 0;
            foreach(MenuCore menuF in Menu.MenuF)
            {
                Console.WriteLine("[{0}] {1}",iMenuItem++,menuF.Title);
            }
        }

    }
}
