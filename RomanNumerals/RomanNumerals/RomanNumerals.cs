using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
    internal class RomanNumerals
    {
        private static readonly Dictionary<int, string> knownRomanSymbols = new Dictionary<int, string>
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {50, "L"},
            {100, "C"},
            {500, "D"},
            {1000, "M"},
        };

        public static string Convert(int arabicNumber)
        {            
            var romanNumberBuilder = new StringBuilder();
            while (arabicNumber > 0)
            {
                var maxMinorValue = knownRomanSymbols.Keys.Where(k => k <= arabicNumber).Max();
                romanNumberBuilder.Append(knownRomanSymbols[maxMinorValue]);
                arabicNumber -= maxMinorValue;

            }
            return romanNumberBuilder.ToString();            
        }
    }
}