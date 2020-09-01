using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalGame002
{
    //轉換成公式
    public static class Calculator
    {
        public static int Calculate(int maxValue)
        {
            if(maxValue % 2 == 0)
            {
                return (maxValue / 2) - maxValue;
            }
            return maxValue - maxValue / 2;
        }
    }
}
