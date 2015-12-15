using System;
using NUnit.Framework;

namespace NUnit3Samples._5._Parameterized_Tests.C._MethodValues._4._Range
{
    [TestFixture]
    public class RangeTests
    {
        [Test]
        public void IntRangeTest([Range(1, 11)] int i)
        {
            
        }

        [Test]
        public void IntRangeEvenTest([Range(0, 12, 2)] int i)
        {
            
        }
    }
}
