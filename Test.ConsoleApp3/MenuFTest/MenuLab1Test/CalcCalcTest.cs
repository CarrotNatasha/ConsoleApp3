using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3;
using ConsoleApp3.MenuF.MenuLab1;

namespace Tests.ConsoleApp3.MenuFTest
{
    [TestFixture]
    public class CalcCalcTest
    {
        [Test]
        public void CalcCalc_CalcFormulaWorks_ok()
        {
            Assert.AreEqual(8, CalcCalc.XYZCalc(3, 1, 3));
        }
    }
}
