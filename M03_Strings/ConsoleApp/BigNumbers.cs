using System.Text;

namespace ConsoleApp
{
    class BigNumbers
    {
        public static string Add (string first, string second)
        {
            System.Diagnostics.Debug.Assert(!string.IsNullOrEmpty (first), "The first string is empty");
            System.Diagnostics.Debug.Assert(!string.IsNullOrEmpty (second), "The second string is empty");

            string shortStr = first.Length < second.Length ? first : second;
            string longStr = first.Length >= second.Length ? first : second;
            shortStr = ModifyString.ReverseString (shortStr);
            longStr = ModifyString.ReverseString (longStr);

            var sb = new StringBuilder();

            bool isCarry = false;
            for (int i = 0; i < longStr.Length; i++)
            {
                int sum = i < shortStr.Length
                    ? (shortStr[i] - '0') + (longStr[i] - '0')
                    : longStr[i] - '0';
                if (isCarry)
                {
                    sum++;
                    isCarry = false;
                }

                if (sum >= 10)
                {
                    isCarry = true;
                    sum -= 10;
                }

                sb.Append (sum);
            }           
            if (isCarry) { sb.Append ('1'); }

            return ModifyString.ReverseString (sb.ToString());
        }
    }
}
