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
    }
}
