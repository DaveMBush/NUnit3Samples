using NUnit.Framework;

namespace NUnit3Samples._7._Advanced.A._Timeout
{
    [TestFixture]
    public class TimeoutTest
    {
        [Test]
        [Timeout(1000)]
        public void Test()
        {

        }
    }
}
