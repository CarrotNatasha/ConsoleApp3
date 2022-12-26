using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3;
using ConsoleApp3.Validation;
using NUnit.Framework;

namespace Test.ConsoleApp3.ValidationsTest.ForInt
{
    [TestFixture]
    public class IsMoreThanZeroTest
    {
        [Test]
        public void IsMoreThanZero_Validate_MoreZero_ok()
        {
            new IsMoreThanZero().Validate(9);
        }
        [Test]
        public void IsMoreThanZero_Validate_LessZero_ThrowValidateException()
        {
            Assert.Throws<ValidationException>(() => new IsMoreThanZero().Validate(-1));
        }
    }
}
