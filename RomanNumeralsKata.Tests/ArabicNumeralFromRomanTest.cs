using System;
using Xunit;

namespace RomanNumeralsKata.Tests
{
    public class ArabicNumeralFromRomanTest
    {
        ArabicNumerals arabicNumerals = new ArabicNumerals();

        [Fact]
        public void When_I_Is_Input_Should_Result_In_1()
        {
            var result = arabicNumerals.FromRoman("I");
            Assert.Equal(1, result);
        }

        [Fact]
        public void When_II_Is_Input_Should_Result_In_2()
        {
            var result = arabicNumerals.FromRoman("II");
            Assert.Equal(2, result);
        }

        [Fact]
        public void When_III_Is_Input_Should_Result_In_3()
        {
            var result = arabicNumerals.FromRoman("III");
            Assert.Equal(3, result);
        }

        [Fact]
        public void When_IV_Is_Input_Should_Result_In_4()
        {
            var result = arabicNumerals.FromRoman("IV");
            Assert.Equal(4, result);
        }

        [Fact]
        public void When_V_Is_Input_Should_Result_In_5()
        {
            var result = arabicNumerals.FromRoman("V");
            Assert.Equal(5, result);
        }
    }
}
