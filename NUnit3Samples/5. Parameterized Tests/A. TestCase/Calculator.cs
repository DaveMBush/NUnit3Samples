namespace NUnit3Samples._5._Parameterized_Tests.A._TestCase
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            checked
            {
                return a + b;
            }
        }
    }
}
