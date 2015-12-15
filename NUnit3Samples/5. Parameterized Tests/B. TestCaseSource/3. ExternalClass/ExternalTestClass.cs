using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnit3Samples._5._Parameterized_Tests.B._TestCaseSource._3._ExternalClass
{
    public class ExternalTestSource
    {
        public static IEnumerable<TestCaseData> TestData
        {
            get
            {
                yield return new
                    TestCaseData(1, 2).Returns(3);
                yield return new
                    TestCaseData(3, 5).Returns(8)
                    .SetName("3 + 5")
                    .SetDescription("Add 3 plus 5");
            }
        }
    }
}
