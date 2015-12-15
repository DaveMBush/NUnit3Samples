using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit3Samples._5._Parameterized_Tests.A._TestCase;

namespace NUnit3Samples._5._Parameterized_Tests.C._MethodValues._2._Combinatorial
{
    [TestFixture]
    class ValuesCombinatorial
    {
        Calculator SUT { get; set; }
        [SetUp]
        public void Setup()
        {
            SUT = new Calculator();
        }

        [Test]
        [Combinatorial]
        public void RunEveryCombination(
            [Values(1, 3, 5)] int a,
            [Values(2, 5, 6)] int b)
        {
            var answer = SUT.Add(a, b);
        }
    }
}
