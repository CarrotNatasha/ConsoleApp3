using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MenuF
{
    public class MenuLab1Calc : MenuCore
    {
        public override string Title { get { return "Calc: Z/X + 7*sqrt(Y)"; } }

        public override void Execute()
        {
            //Z / X + 7 * sqrt(Y)
            double dX=0, dY=0, dZ;
            Console.WriteLine("Write down X");
            dX = MeniuLab1.CalcCalc.XWrite(dX);
            Console.WriteLine("Write down Y");
            dY = MeniuLab1.CalcCalc.YWrite(dY);
            Console.WriteLine("Write down Z");
            dZ = SafeRead.SafeReadInt(null,null);
            double dXYZCalc = Math.Floor((dZ / dX + 7 * Math.Sqrt(dY))*1000)/1000;
            Console.WriteLine(dXYZCalc);
        }
    }
}
