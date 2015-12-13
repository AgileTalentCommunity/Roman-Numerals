using System.Collections.Generic;
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
            if (romanNumbers.ContainsKey(arabicNumber)) return romanNumbers[arabicNumber];

            if (arabicNumber == 2 || arabicNumber == 3)
            {
                var romanNumberBuilder = new StringBuilder();
                while (arabicNumber > 0)
                {
                    romanNumberBuilder.Append("I");
                    arabicNumber--;
                }
                return romanNumberBuilder.ToString();                
            }            
            if (arabicNumber == 4) return "IV";            
            if (arabicNumber == 6) return "VI";
            if (arabicNumber == 7) return "VII";
            if (arabicNumber == 8) return "VIII";
            if (arabicNumber == 9) return "IX";

            return "I";
        }
    }
}