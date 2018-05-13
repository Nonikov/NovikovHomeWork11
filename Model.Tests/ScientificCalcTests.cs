using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Tests
{
    [TestClass]
    public class ScientificCalcTests
    {
        [TestMethod]
        public void TestMethodCalculateString()
        {
            string str = "(5+3)^3*2+2.7-8÷2";
            string expected = "1022.7";

            string actual =  ScientificCalc.CalculateString(str);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodFactorial()
        {
           long num = 17;
            long expected = 355687428096000;

            long actual = ScientificCalc.Factorial(num);

            Assert.AreEqual(expected, actual);
        }
    }
}
