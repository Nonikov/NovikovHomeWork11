using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace Model.Tests
{
    [TestClass]
    public class StatndardCalcTests
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            double oper1 = 6;
            double oper2 = 2.5;
            string expected = "8.5";

            string actual = StatndardCalc.Plus(oper1, oper2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodMinus()
        {
            double oper1 = 6;
            double oper2 = 2.5;
            string expected = "3.5";

            string actual = StatndardCalc.Minus(oper1, oper2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodMul()
        {
            double oper1 = 6;
            double oper2 = 2.5;
            string expected = "15";

            string actual = StatndardCalc.Mul(oper1, oper2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            double oper1 = 6;
            double oper2 = 2.5;
            string expected = "2.4";

            string actual = StatndardCalc.Div(oper1, oper2);

            Assert.AreEqual(expected, actual);
        }
    }
}
