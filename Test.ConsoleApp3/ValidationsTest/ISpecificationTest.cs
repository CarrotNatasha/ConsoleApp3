using ConsoleApp3;
using ConsoleApp3.Validation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.ConsoleApp3.ValidationsTest
{
    [TestFixture]
    public class ISpecificationTest
    {
        [Test]
        public void AndSpecification_AddingSpecifications_ok()
        {
            new AndSpecification<int>(new IsNotZero(), new IsMoreThanZero()).Validate(2);
        }

        [Test]
        public void AndSpecification_NotAddingSpecifications_ThrowValidationEx()
        {
            Assert.Throws<ValidationException>(() =>
            {
                new AndSpecification<int>(new IsNotZero(), new IsMoreThanZero()).Validate(-2);
                new AndSpecification<int>(new IsNotZero(), new IsMoreThanZero()).Validate(0);
            }); 
        }
    }
}
