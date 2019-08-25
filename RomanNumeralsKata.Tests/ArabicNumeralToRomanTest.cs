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

        [Fact]
        public void When_2_Is_Input_Should_Result_In_II()
        {
            var result = arabicNumerals.ToRoman(2);
            Assert.Equal("II", result);
        }

        [Fact]
        public void When_3_Is_Input_Should_Result_In_III()
        {
            var result = arabicNumerals.ToRoman(3);
            Assert.Equal("III", result);
        }
    }
}
