using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit3Samples._5._Parameterized_Tests.A._TestCase;

namespace NUnit3Samples._5._Parameterized_Tests.B._TestCaseSource._3._ExternalClass
{
    [TestFixture]
    class TestUsingExternalTestSource
    {
        Calculator SUT { get; set; }
        [SetUp]
        public void Setup()
        {
            SUT = new Calculator();
        }
        [Test]
        [TestCaseSource(typeof(ExternalTestSource), nameof(ExternalTestSource.TestData))]
        public int AddTest(int a, int b)
        {
            return SUT.Add(a, b);
        }
    }
}
