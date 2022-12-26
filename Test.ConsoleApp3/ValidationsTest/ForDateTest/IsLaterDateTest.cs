using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Validation;
using ConsoleApp3;

namespace Tests.ConsoleApp3.ValidationsTest.ForDate
{
    [TestFixture]
    class IsLaterDateTest
    {
        [Test]
        public void IsLaterDate_Validate_LaterDate_ok()
        {
            DateTime one = new DateTime(2003, 02, 03);
            DateTime two = new DateTime(2004, 04, 03);
            new IsEarlierDate(one).Validate(two);
        }
        [Test]
        public void IsLaterDate_Validate_NotLaterDate_ThrowValidationException()
        {
            DateTime one = new DateTime(2004, 02, 03);
            DateTime two = new DateTime(2003, 04, 03);
            Assert.Throws<ValidationException>(() => new IsEarlierDate(one).Validate(two));
        }
    }
}
