using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    internal class RomanNumerals
    {
        private static readonly Dictionary<int, string> romanNumbers = new Dictionary<int, string>
        {
            {1, "I"},
            {5, "V"},
            {10, "X"},
            {50, "L"},
            {100, "C"},
            {500, "D"},
            {1000, "M"},
        };

        public static string Convert(int arabicNumber)
        {
            if (arabicNumber == 4) return "IV";
            if (arabicNumber == 9) return "IX";
            var romanNumberBuilder = new StringBuilder();
            while (arabicNumber > 0)
            {
                var maxMinorValue = romanNumbers.Keys.Where(k => k <= arabicNumber).Max();
                romanNumberBuilder.Append(romanNumbers[maxMinorValue]);
                arabicNumber -= maxMinorValue;

            }
            return romanNumberBuilder.ToString();            
        }
    }
}