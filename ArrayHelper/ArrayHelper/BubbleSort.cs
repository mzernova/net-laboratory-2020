namespace ArrayHelper
{
    public class BubbleSort
    {
        public static void SortArray (int[] array, bool ASC = true)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    bool isSwap = ASC
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
