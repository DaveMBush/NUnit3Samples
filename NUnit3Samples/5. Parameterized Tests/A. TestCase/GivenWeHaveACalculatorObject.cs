using System;
using NUnit.Framework;

namespace NUnit3Samples._5._Parameterized_Tests.A._TestCase
{
    [TestFixture]
    public class GivenWeHaveACalculatorObject
    {
        Calculator SUT { get; set; }

        [SetUp]
        public void Setup()
        {
            SUT = new Calculator();
        }

        [Test]
        [TestCase(3, 7, ExpectedResult = 10)]
        [TestCase(-2, -3, ExpectedResult = -5)]
        public int AddingTwoNumbersShouldReturnCorrectSum(int a, int b)
        {
            // When I add 3 and 7 together
            var returnValue = SUT.Add(a, b);
            return returnValue;
        }

        [Test]
        public void AddingOneToMaxValueThrowsAnException()
        {
            var exception = Assert.Catch(() => SUT.Add(int.MaxValue, 1));
            Assert.That(exception, Is.TypeOf<OverflowException>());
        }
    }
}
