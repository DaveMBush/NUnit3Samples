using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit3Samples._5._Parameterized_Tests.A._TestCase;

namespace NUnit3Samples._5._Parameterized_Tests.C._MethodValues._1._Sequential
{
    [TestFixture]
    class ValuesSequential
    {
        Calculator SUT { get; set; }
        [SetUp]
        public void Setup()
        {
            SUT = new Calculator();
        }

        [Test]
        [Sequential]
        public void AddTest(
            [Values(1, 3, 5)] int a,
            [Values(2, 5, 6)] int b,
            [Values(3, 8, 11)] int returnValue)
        {
            var answer = SUT.Add(a, b);
            Assert.That(answer,Is.EqualTo(returnValue));
        }
    }
}
