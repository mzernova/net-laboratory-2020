using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class ModifyString
    {
        public static string ReverseString (string s)
        {
            System.Diagnostics.Debug.Assert(!string.IsNullOrEmpty (s), "The string is empty");
            char[] arr = s.ToCharArray();
            Array.Reverse (arr);
            return new string (arr);
        }

        public static string DoubleStringCharacters(string first, string second)
        {
            System.Diagnostics.Debug.Assert (!string.IsNullOrEmpty (first), "The first string is empty");
            System.Diagnostics.Debug.Assert (!string.IsNullOrEmpty (second), "The second string is empty");

            IEnumerable<char> characters = second.Distinct();
            var sb = new StringBuilder();

            foreach (var ch in first)
            {
                if (characters.Contains (ch) && ch != ' ')
                {
                    sb.Append (ch, 2);
                }
                else
                {
                    sb.Append (ch);
                }
            }

            return sb.ToString();
        }

        public static string ReverseWords (string str)
        {
            System.Diagnostics.Debug.Assert (!string.IsNullOrEmpty (str), "The string is empty");
            string[] words = str.Split (' ');
            Array.Reverse (words);
            return string.Join (" ", words);
        }
    }
}
