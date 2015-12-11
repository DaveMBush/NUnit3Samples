using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit3Samples._4._Basic_Testing.C.Test_Code
{
    [TestFixture]
    class ArrangeActAssert
    {
        [Test]
        public void AddShouldReturnSumOfTwoNumbers()
        {
            // Arrange
            var sut = new Calculator();

            // Act
            var returnValue = sut.Add(3, 7);

            // Assert
            Assert.That(returnValue, Is.EqualTo(10));
        }
    }
}
