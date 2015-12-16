using NUnit.Framework;

namespace NUnit3Samples._6._Managing_Tests.B._GroupingTests._1._Categories
{
    [Category("One")]
    [TestFixture]
    public class CategoryExample
    {
        [Test]
        public void SomeTestOne()
        {
            
        }

        [Category("Two")]
        [Test]
        public void SomeTestTwo()
        {

        }
    }
}
