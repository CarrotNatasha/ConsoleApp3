using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.MenuF.MenuLab3;

namespace Tests.ConsoleApp3.MenuFTest
{
    [TestFixture]
    public class StringCalcTest
    {
        [Test]
        public void ReverseStringCalc_ReverseText()
        {
            Assert.AreEqual("agubagu", StringCalc.ReverseStr("ugabuga"));
        }

        [TestCase("qwerty", 1)]
        [TestCase("asdfgh", 0)]
        public void WriteDownStringCalc_WriteDownEqual(string sValue, int iResult)
        {
            Assert.AreEqual(iResult, StringCalc.WriteDown(sValue,"qwerty"));
        }

        [Test]
        public void BeautifyingStringCalc_BeautifyingTextNoSpaces()
        {
            Assert.AreEqual("wrong answer", StringCalc.Beautifying("      WrOnG   aNsWeR     "));
        }

        [TestCase("dfghj@gmail.com",1)]
        [TestCase("192.0.2.1", 1)]
        [TestCase("+71231231234", 1)]
        [TestCase("eorijgflek", 0)]
        public void RegexTestStringCalc_RegexTest(string sValue, int iResult)
        {
            Assert.AreEqual(iResult, StringCalc.RegexTest(sValue));
        }
    }
}
