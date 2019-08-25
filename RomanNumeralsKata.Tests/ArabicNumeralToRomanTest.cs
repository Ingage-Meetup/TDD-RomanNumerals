using System;
using Xunit;
using RomanNumeralsKata;

namespace RomanNumeralsKata.Tests
{
    public class ArabicNumeralToRomanTest
    {
        ArabicNumerals arabicNumerals = new ArabicNumerals();

        [Fact]
        public void When_1_Is_Input_Should_Result_In_I()
        {
            var result = arabicNumerals.ToRoman(1);
            Assert.Equal("I", result);
        }
    }
}
