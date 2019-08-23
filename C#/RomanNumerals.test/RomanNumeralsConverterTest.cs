using RomanNumerals.lib;
using System;
using Xunit;

namespace RomanNumerals.test
{
    /// <summary>
    /// Before implementing the solution, I thought of all the cases I needed to handle, and wrote the tests for each case,
    /// in the order they appear below. Then I started implementing the "ConvertRomanNumeralsToArabic" method, only making the
    /// next test pass. The end result works, but I can see there is a lot of refactoring I could do.
    /// </summary>
    public class RomanNumeralsConverterTest
    {
        private readonly RomanNumeralsConverter Fixture = new RomanNumeralsConverter();

        [Fact]
        public void SingleRomanNumeralsShouldReturnProperIntegerValues()
        {
            Assert.Equal(1, Fixture.ConvertRomanNumeralsToArabic("i"));
            Assert.Equal(5, Fixture.ConvertRomanNumeralsToArabic("v"));
            Assert.Equal(10, Fixture.ConvertRomanNumeralsToArabic("x"));
            Assert.Equal(50, Fixture.ConvertRomanNumeralsToArabic("l"));
            Assert.Equal(100, Fixture.ConvertRomanNumeralsToArabic("c"));
            Assert.Equal(500, Fixture.ConvertRomanNumeralsToArabic("d"));
            Assert.Equal(1000, Fixture.ConvertRomanNumeralsToArabic("m"));
        }

        [Fact]
        public void CertainRepeatedNumeralsShouldBeAdditive()
        {
            Assert.Equal(2, Fixture.ConvertRomanNumeralsToArabic("ii"));
            Assert.Equal(3, Fixture.ConvertRomanNumeralsToArabic("iii"));
            Assert.Equal(20, Fixture.ConvertRomanNumeralsToArabic("xx"));
            Assert.Equal(30, Fixture.ConvertRomanNumeralsToArabic("xxx"));
            Assert.Equal(200, Fixture.ConvertRomanNumeralsToArabic("cc"));
            Assert.Equal(300, Fixture.ConvertRomanNumeralsToArabic("ccc"));
            Assert.Equal(2000, Fixture.ConvertRomanNumeralsToArabic("mm"));
            Assert.Equal(3000, Fixture.ConvertRomanNumeralsToArabic("mmm"));
        }

        [Fact]
        public void CertainNumeralsShouldSubtractFromNext()
        {
            Assert.Equal(4, Fixture.ConvertRomanNumeralsToArabic("iv"));
            Assert.Equal(9, Fixture.ConvertRomanNumeralsToArabic("ix"));
            Assert.Equal(40, Fixture.ConvertRomanNumeralsToArabic("xl"));
            Assert.Equal(90, Fixture.ConvertRomanNumeralsToArabic("xc"));
            Assert.Equal(400, Fixture.ConvertRomanNumeralsToArabic("cd"));
            Assert.Equal(900, Fixture.ConvertRomanNumeralsToArabic("cm"));
        }

        [Fact]
        public void ManyValidRomanNumeralsShouldReturnProperValues()
        {
            Assert.Equal(1984, Fixture.ConvertRomanNumeralsToArabic("mcmlxxxiv"));
            Assert.Equal(1973, Fixture.ConvertRomanNumeralsToArabic("mcmlxxiii"));
            Assert.Equal(1815, Fixture.ConvertRomanNumeralsToArabic("mdcccxv"));
            // This is the largest number you can represent, without using bars over the characters
            Assert.Equal(3999, Fixture.ConvertRomanNumeralsToArabic("mmmcmxcix"));
        }

        [Fact]
        public void InvalidRomanNumeralCharactersShouldNotBeAllowed()
        {
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("a"));
        }

        [Fact]
        public void CharactersShouldNotBeAllowedToRepeatMoreThanThreeTimes()
        {
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("iiii"));
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("xxxx"));
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("cccc"));
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("mmmm"));
        }

        [Fact]
        public void CertainCharactersShouldNotBeAllowedToRepeat()
        {
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("vv"));
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("ll"));
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("dd"));
        }

        [Fact]
        public void RomanNumeralsMustBeOrderedFromLargestToSmallestExceptForAllowedSubtractions()
        {
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("mdm"));
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("clc"));
            Assert.Throws<ArgumentException>(() => Fixture.ConvertRomanNumeralsToArabic("xvx"));

        }
    }
}
