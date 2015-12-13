using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace RomanNumerals
{
    public class RomanNumeralsTests
    {               

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        [TestCase(900, "CM")]
        [TestCase(400, "CD")]
        [TestCase(90, "XC")]
        [TestCase(40, "XL")]
        [TestCase(1990, "MCMXC")]
        [TestCase(2008, "MMVIII")]
        public void Should_return_roman_number_for_the_arabic_number(int arabicNumber, string expectedRomanNumber)
        {
            string actual = RomanNumerals.Convert(arabicNumber);
            Check.That(actual).IsEqualTo(expectedRomanNumber);
        }
    }
}
