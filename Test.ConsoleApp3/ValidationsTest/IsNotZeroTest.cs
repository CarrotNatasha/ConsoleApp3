using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Validation;
using NUnit.Framework;

namespace Test.ConsoleApp3.ValidationsTest
{
    [TestFixture]
    public class IsNotZeroTest
    {
        [Test]
        public void IsNotZero_Validate_wZero_ok()
        {
            new IsNotZero().Validate(0);
        }
        [Test]
        public void IsNotZero_Validate_wNonZero_ThrowValidationEx()
        {
            new IsNotZero().Validate(10);
        }
    }
}
