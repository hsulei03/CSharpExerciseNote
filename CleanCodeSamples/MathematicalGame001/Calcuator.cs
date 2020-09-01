namespace MathematicalGame001
{

    /// <summary>
    /// 給定一個整數值 max，max 必須大於 1
    /// 若 max 為奇數則計算 1-2+3-4+5-6+…+max
    /// 若 max 為偶數則計算 1-2+3-4+5-6+7-…-max
    /// </summary>
    public static class Calcuator
    {
        public static int Calculate(int maxValue)
        {
            int result = 0;
            if (maxValue > 1)
            {
                for (int i = 1; i <= maxValue; i++)
                {
                    if (i % 2 == 0)
                    {
                        //為偶數用減
                        result -= i;
                    }
                    else
                    {
                        //為奇數用加
                        result += i;
                    }
                }
            }

            return result;
        }
    }
}
