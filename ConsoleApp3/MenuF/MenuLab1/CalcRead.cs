using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Validation;

namespace ConsoleApp3.MenuF.MenuLab1
{
    public static class CalcRead
    {
        public static double XWrite(double dX)
        {
            dX = SafeRead.SafeReadInt("x", "", new IsNotZero());
            return dX;
        }

        public static double YWrite(double dY)
        {
            dY = SafeRead.SafeReadInt("y", "", new IsMoreThanZero());
            return dY;
        }

        public static double ZWrite(double dZ)
        {
            dZ = SafeRead.SafeReadInt("z", null);
            return dZ;
        }
    }
}
