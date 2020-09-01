using System;
using System.Globalization;
using MathematicalGame001;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathematicalGame001Tests
{
    [TestClass]
    public class CalcuatorTests
    {
        [DataTestMethod()] //DataTestMethod 屬性代表一套測試，這套測試會執行相同的程式碼，但具有不同的輸入引數。 
        [DataRow(11, 6)]//搭配 DataRow 屬性來指定這些輸入的值。
        [DataRow(6, -3)]
        [DataRow(15, 8)]
        [DataRow(8,-4)]
        [DataRow(0, 0)]
        public void CalculateTest(int maxValue,int expected)
        {
            int actual = Calcuator.Calculate(maxValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
