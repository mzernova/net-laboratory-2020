using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayHelper
{
    public class SumNumbers
    {
        public static int SumPositiveNumbers(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
