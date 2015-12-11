using System;
using NUnit.Framework;

namespace NUnit3Samples._3._Getting_Started
{

    [TestFixture]
    public class Class1WithConsoleWriteLine
    {
        [Test]
        public void MyFirstTestMethod()
        {
            Console.WriteLine("Inside MyFirstTestMethod");
        }
    }

}
