using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit3Samples._5._Parameterized_Tests.A._TestCase;

namespace NUnit3Samples._5._Parameterized_Tests.B._TestCaseSource._2._IEnumerableTestCaseData
{
    [TestFixture]
    public class GivenWeHaveACalculatorObject
    {
        Calculator SUT { get; set; }
        public static IEnumerable SourceProperty
        {
            get
            {
                yield return new TestCaseData(1, 2).Returns(3);
                yield return new TestCaseData(3, 5).Returns(8)
                    .SetName("3 + 5")
                    .SetDescription("Add 3 plus 5");
            }
        }

        [SetUp]
        public void Setup()
        {
            SUT = new Calculator();
        }

        [Test]
        [TestCaseSource(nameof(SourceProperty))]
        public int AddingTwoNumbersShouldReturnCorrectSum(int a, int b)
        {
            return SUT.Add(a, b);
        }
    }
}
