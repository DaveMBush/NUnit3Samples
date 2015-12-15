using NUnit.Framework;

namespace NUnit3Samples._5._Parameterized_Tests.C._MethodValues._3._Random
{
    [TestFixture]
    public class RandomTests
    {
        [Test]
        public void RandomDoubleTest([Random(4)] double d)
        {
            
        }

        [Test]
        public void RandomIntTest([Random(int.MinValue,int.MaxValue,4)] int i)
        {
            
        }

        [Test]
        public void RandomDoubleTest2([Random(-1.0, 1.0, 6)] double d)
        {
            
        }
    }
}
