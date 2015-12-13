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
    }

    internal class RomanNumerals
    {
        public static string Convert(int i)
        {
            return "I";
        }
    }
}
