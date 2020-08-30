using System.Collections.Generic;
using System.Text;

namespace ConsoleApps.Solutions
{
    public class Seventeen
    {
        private const int endNumber = 1000;

        public int NumberLetterCount()
        {
            return ProgrammaticMethod();
        }

        private int ProgrammaticMethod()
        {
            int numberCount = 0;

            for (int i = 1; i <= endNumber; i++)
            {
                numberCount += i.ToEnglishWord().Length;
            }

            return numberCount;
        }
    }
}

public static class Extensions
{
    private static readonly Dictionary<int, string> numWordDictionary = new Dictionary<int, string>
    {
        { 1, "one" },
        { 2, "two" },
        { 3, "three" },
        { 4, "four" },
        { 5, "five" },
        { 6, "six" },
        { 7, "seven" },
        { 8, "eight" },
        { 9, "nine" },
        { 10, "ten" },
        { 11, "eleven" },
        { 12, "twelve" },
        { 13, "thirteen" },
        { 14, "fourteen" },
        { 15, "fifteen" },
        { 16, "sixteen" },
        { 17, "seventeen" },
        { 18, "eighteen" },
        { 19, "nineteen" },
        { 20, "twenty"},
        { 30, "thirty" },
        { 40, "forty" },
        { 50, "fifty" },
        { 60, "sixty" },
        { 70, "seventy" },
        { 80, "eighty" },
        { 90, "ninety" },
        { 100, "hundred" },
        { 1000, "thousand" },
    };

    /// <summary>
    /// Converts an integer to its English language representation.
    /// </summary>
    /// <param name="number"></param>
    /// <returns>English language string.</returns>
    public static string ToEnglishWord(this int num)
    {
        StringBuilder sb = new StringBuilder();

        // Thousand
        if (num == 1000)
            return "onethousand";

        // Hundreds
        if (num > 99)
        {
            sb.Append(numWordDictionary.GetValueOrDefault(num / 100));
            sb.Append("hundred");

            num %= 100;

            if (num > 0)
            {
                sb.Append("and");
            }
        }

        if (num == 0)
        {
            return sb.ToString();
        }

        // Special handling for 1-19
        if (num < 20)
        {
            sb.Append(numWordDictionary.GetValueOrDefault(num));
        }
        else
        {
            // Tens
            sb.Append(numWordDictionary.GetValueOrDefault((num / 10) * 10));

            // Ones
            sb.Append(numWordDictionary.GetValueOrDefault(num % 10));
        }

        return sb.ToString();
    }
}
