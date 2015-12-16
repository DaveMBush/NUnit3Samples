using NUnit.Framework;

namespace NUnit3Samples._7._Advanced.B._MaxTime
{
    [TestFixture]
    public class MaxtimeTest
    {
        [Test]
        [MaxTime(1000)]
        public void Test()
        {
        }
    }

}
