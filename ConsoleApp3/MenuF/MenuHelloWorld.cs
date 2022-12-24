using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MenuF
{
    public class MenuHelloWorld : MenuCore
    {
        public override string Title { get { return "Hello world!"; } }

        public override void Execute()
        {
            Console.WriteLine("\nHello world!\n\n");
        }
    }
}
