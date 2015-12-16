using NUnit.Framework;

namespace NUnit3Samples._6._Managing_Tests.B._GroupingTests._2._PreventingTestFromRunning
{
    [TestFixture]
    public class ExplicitTestMethod
    {
        [Test]
        [Explicit]
        public void Test()
        {

        }
    }
}
