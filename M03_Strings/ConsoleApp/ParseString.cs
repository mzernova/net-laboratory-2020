using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ParseString
    {
        public static string[] FindNumbers (string text)
        {
            System.Diagnostics.Debug.Assert (!string.IsNullOrEmpty (text), "The string is empty");

            Regex rgx = new Regex(@"(\+)?(\d{1,3})[- _]*\(?[- _]*(\d{2,3}[- _]*\)?([- _]*\d){7}|\d\d[- _]*\d\d[- _]*\)?([- _]*\d){6})");
            MatchCollection aMatches = rgx.Matches (text);

            var result = new string [aMatches.Count];
            for (int i = 0; i < aMatches.Count; i++)
            {
                result[i] = aMatches[i].Value;
            }

            return result;
        }
    }
}
