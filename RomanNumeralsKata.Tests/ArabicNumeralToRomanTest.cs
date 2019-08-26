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
        public void When_8_Is_Input_Should_Result_In_VIII()
        {
            var result = arabicNumerals.ToRoman(8);
            Assert.Equal("VIII", result);
        }

        [Fact]
        public void When_9_Is_Input_Should_Result_In_IX()
        {
            var result = arabicNumerals.ToRoman(9);
            Assert.Equal("IX", result);
        }

        [Fact]
        public void When_10_Is_Input_Should_Result_In_X()
        {
            var result = arabicNumerals.ToRoman(10);
            Assert.Equal("X", result);
        }

        
        [Fact]
        public void When_11_Is_Input_Should_Result_In_XI()
        {
            var result = arabicNumerals.ToRoman(11);
            Assert.Equal("XI", result);
        }

        [Fact]
        public void When_12_Is_Input_Should_Result_In_XII()
        {
            var result = arabicNumerals.ToRoman(12);
            Assert.Equal("XII", result);
        }

        [Fact]
        public void When_13_Is_Input_Should_Result_In_XIII()
        {
            var result = arabicNumerals.ToRoman(13);
            Assert.Equal("XIII", result);
        }

        [Fact]
        public void When_14_Is_Input_Should_Result_In_XIV()
        {
            var result = arabicNumerals.ToRoman(14);
            Assert.Equal("XIV", result);
        }

        [Fact]
        public void When_19_Is_Input_Should_Result_In_XIX()
        {
            var result = arabicNumerals.ToRoman(19);
            Assert.Equal("XIX", result);
        }

        [Fact]
        public void When_20_Is_Input_Should_Result_In_XX()
        {
            var result = arabicNumerals.ToRoman(20);
            Assert.Equal("XX", result);
        }

        [Fact]
        public void When_40_Is_Input_Should_Result_In_XL()
        {
            var result = arabicNumerals.ToRoman(40);
            Assert.Equal("XL", result);
        }

        [Fact]
        public void When_50_Is_Input_Should_Result_In_L()
        {
            var result = arabicNumerals.ToRoman(50);
            Assert.Equal("L", result);
        }

        [Fact]
        public void When_99_Is_Input_Should_Result_In_XCIX()
        {
            var result = arabicNumerals.ToRoman(99);
            Assert.Equal("XCIX", result);
        }

        [Fact]
        public void When_100_Is_Input_Should_Result_In_C()
        {
            var result = arabicNumerals.ToRoman(100);
            Assert.Equal("C", result);
        }

        [Fact]
        public void When_300_Is_Input_Should_Result_In_CCC()
        {
            var result = arabicNumerals.ToRoman(300);
            Assert.Equal("CCC", result);
        }
    }
}
