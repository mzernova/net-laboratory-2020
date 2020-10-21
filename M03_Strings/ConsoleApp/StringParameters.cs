namespace ConsoleApp
{
    class StringParameters
    {
        public static double GetAverageWordLength (string str)
        {
            System.Diagnostics.Debug.Assert (!string.IsNullOrWhiteSpace (str), "Empty string");

            char[] separators = {' ', '.', ',', '!', '?', ':', ';' };
            string[] words = str.Split (separators);

            double sum = 0;
            int wordsNb = 0;

            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace (word))
                {
                    sum += word.Length;
                    wordsNb++;
                }
            }

            return wordsNb == 0 ? 0 : sum / wordsNb;
        }     
    }
}
