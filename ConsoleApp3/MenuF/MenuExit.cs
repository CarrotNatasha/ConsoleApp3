using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MenuF
{
    public class MenuExit : MenuCore
    {
        public override string Title { get { return "Exit"; } }

        public override void Execute()
        {
            Console.WriteLine("Exit...");
            Environment.Exit(0);
        }
    }
}
