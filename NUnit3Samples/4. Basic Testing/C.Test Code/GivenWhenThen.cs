using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit3Samples._4._Basic_Testing.C.Test_Code
{
    [TestFixture]
    class GivenWhenThen
    {
        [Test]
        public void AddShouldReturnSumOfTwoNumbers()
        {
            // Given that we have a calculator
            var sut = new Calculator();

            // When I add 3 and 7 together
            var returnValue = sut.Add(3, 7);

            // Then the result should be 10
            Assert.That(returnValue, Is.EqualTo(10));
        }
    }
}
