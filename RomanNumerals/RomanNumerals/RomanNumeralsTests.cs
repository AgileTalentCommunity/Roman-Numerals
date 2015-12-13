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

        [Test]
        public void Should_return_VI_when_arabic_number_is_6()
        {
            string actual = RomanNumerals.Convert(6);
            Check.That(actual).IsEqualTo("VI");
        }

        [Test]
        public void Should_return_VII_when_arabic_number_is_7()
        {
            string actual = RomanNumerals.Convert(7);
            Check.That(actual).IsEqualTo("VII");
        }

        [Test]
        public void Should_return_VIII_when_arabic_number_is_8()
        {
            string actual = RomanNumerals.Convert(8);
            Check.That(actual).IsEqualTo("VIII");
        }

        [Test]
        public void Should_return_IX_when_arabic_number_is_9()
        {
            string actual = RomanNumerals.Convert(9);
            Check.That(actual).IsEqualTo("IX");
        }

        [Test]
        public void Should_return_X_when_arabic_number_is_10()
        {
            string actual = RomanNumerals.Convert(10);
            Check.That(actual).IsEqualTo("X");
        }

        [Test]
        public void Should_return_L_when_arabic_number_is_50()
        {
            string actual = RomanNumerals.Convert(50);
            Check.That(actual).IsEqualTo("L");
        }

        [Test]
        public void Should_return_C_when_arabic_number_is_100()
        {
            string actual = RomanNumerals.Convert(100);
            Check.That(actual).IsEqualTo("C");
        }

        [Test]
        public void Should_return_D_when_arabic_number_is_500()
        {
            string actual = RomanNumerals.Convert(500);
            Check.That(actual).IsEqualTo("D");
        }

        [Test]
        public void Should_return_M_when_arabic_number_is_1000()
        {
            string actual = RomanNumerals.Convert(1000);
            Check.That(actual).IsEqualTo("M");
        }
    }
}
