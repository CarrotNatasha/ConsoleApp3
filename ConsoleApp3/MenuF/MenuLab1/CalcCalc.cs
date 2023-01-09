using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Validation;

namespace ConsoleApp3.MenuF.MenuLab1
{
    public static class CalcCalc
    {
        public static double XYZCalc(double dX, double dY, double dZ)
        {
            double dXYZ = (dZ / dX) + (7 * Math.Sqrt(dY));
            return dXYZ;
        }
    }
}
