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
            double dX = 0, dY = 0, dZ = 0;
            Console.WriteLine("Write down X");
            dX = MenuLab1.CalcRead.XWrite(dX);
            Console.WriteLine("Write down Y");
            dY = MenuLab1.CalcRead.YWrite(dY);
            Console.WriteLine("Write down Z");
            dZ = MenuLab1.CalcRead.ZWrite(dZ);
            double dXYZ = MenuLab1.CalcCalc.XYZCalc(dX, dY, dZ);
            string sResult = dXYZ.ToString("#.###");
            Console.WriteLine("The result = {0}", sResult);
        }
    }
}
