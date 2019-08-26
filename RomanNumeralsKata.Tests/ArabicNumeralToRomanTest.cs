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

        [Fact]
        public void When_4_Is_Input_Should_Result_In_IV()
        {
            var result = arabicNumerals.ToRoman(4);
            Assert.Equal("IV", result);
        }

        [Fact]
        public void When_5_Is_Input_Should_Result_In_V()
        {
            var result = arabicNumerals.ToRoman(5);
            Assert.Equal("V", result);
        }

        [Fact]
        public void When_6_Is_Input_Should_Result_In_VI()
        {
            var result = arabicNumerals.ToRoman(6);
            Assert.Equal("VI", result);
        }

        [Fact]
        public void When_7_Is_Input_Should_Result_In_VII()
        {
            var result = arabicNumerals.ToRoman(7);
            Assert.Equal("VII", result);
        }

        [Fact]
        public void When_7_Is_Input_Should_Result_In_VIII()
        {
            var result = arabicNumerals.ToRoman(8);
            Assert.Equal("VIII", result);
        }
    }
}
