using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsKata
{
    public class ArabicNumerals
    {
        const int MaxRomanNumeral = 3899;

        Dictionary<string, int> RomanLookup = new Dictionary<string, int>();

        public string ToRoman(int input) 
        {   
            var result = new StringBuilder();

            if (input < 1 || input > MaxRomanNumeral)
            {
                throw new ArgumentOutOfRangeException($"Value must be between 1 and {MaxRomanNumeral}");
            }

            while (input >= 1000) {
                input -= 1000;
                result.Append("M");                
            }

            if (input >= 900) {
                input -= 900;
                result.Append("CM");
            }

            if (input >= 500) {
                input -= 500;
                result.Append("D");                
            }

            if (input >= 400) {
                input -= 400;
                result.Append("CD");
            }

            while (input >= 100) {
                input -= 100;
                result.Append("C");                
            }

            if (input >= 90) {
                input -= 90;
                result.Append("XC");
            }
            
            if (input >= 50) {
                input -= 50;
                result.Append("L");
            } 

            if (input >= 40) {
                input -= 40;
                result.Append("XL");
            } 

            while (input >= 10) {
                input -= 10;
                result.Append("X");                
            }

            if (input >= 9) {
                input -= 9;
                result.Append("IX");
            } 

            if (input >= 5) {
                input -= 5;
                result.Append("V");
            }

            if (input >= 4) {
                input -= 4;
                result.Append("IV");
            }

            while (input >= 1) {
                input -= 1;
                result.Append("I");
            }
            
            return result.ToString();
        }

        public int FromRoman(string input)
        {
            for(int index = 1; index <= MaxRomanNumeral; index++)
            {
                RomanLookup[ToRoman(index)] = index;
            }

            if (RomanLookup.ContainsKey(input) == false) 
            {
                throw new ArgumentException($"Value {input} is not a valid roman numeral");
            }

            return RomanLookup[input];
        }
    }
}
