using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.MenuF.MenuLab2;

namespace Tests.ConsoleApp3.MenuFTest.MenuLab2Test
{
    [TestFixture]
    public class DateCalcTest
    {
        [Test]
        public void RecursionAkermann_AkermanCalc_ok()
        {
            Assert.AreEqual(6, DateCalc.RecursionAkermann(6, 5));
        }
        [Test]
        public void DateWriteiMDateCalc_DateCountiM()
        {
            Assert.AreEqual(6, DateCalc.DateWriteiM(new DateTime(2003,03,03),new DateTime(2003,03,10),new DateTime(2003,03,05),new DateTime(2003,03,15)));
        }
    }
}
