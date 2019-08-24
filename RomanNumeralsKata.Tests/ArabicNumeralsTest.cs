using System;
using Xunit;

namespace RomanNumeralsKata.Tests
{
    public class ArabicNumeralsTest
    {
        ArabicNumerals arabicNumerals = new ArabicNumerals();

        [Fact]
        public void When_1_Is_Input_Should_Result_In_I()
        {
            var result = arabicNumerals.ConvertToRoman(1);
            Assert.Equal("I", result);
        }
    }
}
