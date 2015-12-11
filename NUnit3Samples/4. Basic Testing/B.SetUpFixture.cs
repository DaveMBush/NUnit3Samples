using System;
using NUnit.Framework;

namespace NUnit3Samples._4._Basic_Testing
{
	[SetUpFixture]
    public class SetupFixture
    {
	    [OneTimeSetUp]
	    public void OneTimeSetUp()
	    {
	        Console.WriteLine("This code runs once before all test in this namespace or children namespaces.");
	    }

	    [OneTimeTearDown]
	    public void OneTimeTearDown()
	    {
	        Console.WriteLine("This code runs once before all test in this namespace or children namespaces");
	    }
    }
}
