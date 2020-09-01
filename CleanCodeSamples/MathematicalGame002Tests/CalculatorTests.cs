using System;
using MathematicalGame002;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathematicalGame002Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(11, 6)]
        [DataRow(12, -6)]
        [DataRow(9, 5)]
        [DataRow(8, -4)]
        public void CalculateTest(int maxValue,int expected)
        {
            int actual = Calculator.Calculate(maxValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
