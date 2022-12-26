using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3;
using ConsoleApp3.Validation;
using NUnit.Framework;

namespace Test.ConsoleApp3.ValidationsTest
{
    [TestFixture]
    public class IsNotZeroTest
    {
        [Test]
        public void IsNotZero_Validate_wZero_ThrowValidationEx()
        {
            Assert.Throws<ValidationException>(() => new IsNotZero().Validate(0));
        }
        [Test]
        public void IsNotZero_Validate_wNonZero_ok()
        {
            new IsNotZero().Validate(10);
        }
    }
}
