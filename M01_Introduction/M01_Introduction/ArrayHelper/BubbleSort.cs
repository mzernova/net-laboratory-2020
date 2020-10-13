using System.Diagnostics;

namespace ArrayHelper
{
    public enum SortOrder
    {
        ASC,
        DESC
    }

    public class BubbleSort
    {
        public static void SortArray (int[] array, SortOrder order)
        {
            Debug.Assert (array.Length != 0, "Empty array");

            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    bool isSwap = order == SortOrder.ASC
                        ? array[j] > array[j + 1]
                        : array[j] < array[j + 1];
                    if (isSwap)
                    {
                        temp = array [j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
