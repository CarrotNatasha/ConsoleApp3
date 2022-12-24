using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.MenuF.MeniuLab1
{
    public static class CalcCalc
    {
        public static double XWrite(double dX)
        {
            do
            {
                dX = SafeRead.SafeReadInt(null,null);
                if (dX == 0)
                {
                    Console.WriteLine("ERROR: Impossible number. Try Again\n");
                }
            } while (dX == 0);
            return dX;
        }

        public static double YWrite(double dY)
        {
            do
            {
                dY = SafeRead.SafeReadInt(null,null);
                if (dY < 0)
                {
                    Console.WriteLine("ERROR: Impossible number. Try Again\n");
                }
            } while (dY < 0);
            return dY;
        }
    }
}
