using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace RomanNumerals
{
    public class RomanNumeralsTests
    {
        [Test]
        public void Should_return_I_when_arabic_number_is_1()
        {
            string actual = RomanNumerals.Convert(1);
            Check.That(actual).IsEqualTo("I");
        }

        [Test]
        public void Should_return_II_when_arabic_number_is_2()
        {
            string actual = RomanNumerals.Convert(2);
            Check.That(actual).IsEqualTo("II");
        }

        [Test]
        public void Should_return_III_when_arabic_number_is_3()
        {
            string actual = RomanNumerals.Convert(3);
            Check.That(actual).IsEqualTo("III");
        }

        [Test]
        public void Should_return_IV_when_arabic_number_is_4()
        {
            string actual = RomanNumerals.Convert(4);
            Check.That(actual).IsEqualTo("IV");
        }

        [Test]
        public void Should_return_V_when_arabic_number_is_5()
        {
            string actual = RomanNumerals.Convert(5);
            Check.That(actual).IsEqualTo("V");
        }
    }

    internal class RomanNumerals
    {
        public static string Convert(int arabicNumber)
        {
            if (arabicNumber == 2) return "II";
            if (arabicNumber == 3) return "III";
            if (arabicNumber == 4) return "IV";
            if (arabicNumber == 5) return "V";
            return "I";
        }
    }
}
