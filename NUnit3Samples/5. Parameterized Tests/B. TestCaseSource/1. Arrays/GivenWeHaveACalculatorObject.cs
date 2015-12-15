using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit3Samples._5._Parameterized_Tests.A._TestCase;

namespace NUnit3Samples._5._Parameterized_Tests.B._TestCaseSource._1._Arrays
{
    [TestFixture]
    public class GivenWeHaveACalculatorObject
    {
        Calculator SUT { get; set; }

        static readonly object[] SourceProperty =
        {
            new object[]{1,2,3},
            new object[]{3,5,8}
        };

        [SetUp]
        public void Setup()
        {
            SUT = new Calculator();
        }

        [Test]
        [TestCaseSource(nameof(SourceProperty))]
        public void AddingTwoNumbersShouldReturnCorrectSum
            (int a, int b, int returnValue)
        {
            Assert.That(SUT.Add(a, b), Is.EqualTo(returnValue));
        }
    }
}
