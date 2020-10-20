using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string average = "In the Choose a strong name key file box, choose Browse, and then navigate to the key file.";
            Console.WriteLine ("Test string : " + average);
            Console.WriteLine ("Average word length in an input string : " + StringParameters.GetAverageWordLength (average));
            Console.WriteLine();

            string first = "omg i love shrek";
            string second = "o kek";
            Console.WriteLine ("First string  : " + first );
            Console.WriteLine ("Second string : " + second);
            Console.WriteLine ("Double in the first string all characters belonging the second string : " + ModifyString.DoubleStringCharacters (first, second));
            Console.WriteLine();

            string num1 = "4455654687987909809545646464654518643";
            string num2 = "515648643166431545641351315";
            Console.WriteLine ("First number  : " + num1);
            Console.WriteLine ("Second number : " + num2);
            Console.WriteLine ("Sum of two big numbers : " + BigNumbers.Add (num1, num2));
            Console.WriteLine();

            string reverse = "The greatest victory is that which requires no battle";
            Console.WriteLine ("Test string : " + reverse);
            Console.WriteLine ("Reverse all of the words within the string : " + ModifyString.ReverseWords (reverse));
            Console.WriteLine();

            try
            {
                string text = File.ReadAllText("../../../Text.txt");
                string[] numbers = ParseString.FindNumbers(text);
                StreamWriter sw = new StreamWriter("../../../Numbers.txt", false, Encoding.Default);
                Console.WriteLine("Numbers : ");
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                    sw.WriteLine(number);
                }
                sw.Close();
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine ("Directory not found " + ex.ToString());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found " + ex.ToString());
            }
        }
    }
}
