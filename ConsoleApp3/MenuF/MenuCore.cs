using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MenuF
{
    public abstract class MenuCore
    {
        public abstract string Title { get; }

        public abstract void Execute();  
    }
}
