using System;

namespace ConsoleApplication
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Source array");
            PrintArray (array1);

            Console.WriteLine("Descending sort");
            ArrayHelper.BubbleSort.SortArray (array1, ArrayHelper.SortOrder.DESC);
            PrintArray(array1);

            Console.WriteLine("Sort the resulting array in ascending order");
            ArrayHelper.BubbleSort.SortArray (array1, ArrayHelper.SortOrder.ASC);
            PrintArray(array1);

            int[,] array2 = {{ -1,  2, -3},
                             {  4, -5,  6},
                             { -7,  8,  9}};

            Console.WriteLine ("Two-dimensional array");
            PrintArray(array2);

            Console.WriteLine ("Sum of positive array elements : " + ArrayHelper.SumNumbers.SumPositiveNumbers(array2) + "\n");

            Console.WriteLine("Rectangle with sides 9 and 7");
            Rectangle.Rectangle rectangle = new Rectangle.Rectangle(9, 7);
            Console.WriteLine("Its perimeter : " + RectangleHelper.RectangleHelper.Perimeter (rectangle));
            Console.WriteLine("Its square    : " + RectangleHelper.RectangleHelper.Square (rectangle));
        }
    }
}
