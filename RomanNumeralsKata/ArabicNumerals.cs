using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsKata
{
    public class ArabicNumerals
    {
        const int MaxRomanNumeral = 40;

        Dictionary<string, int> RomanLookup = new Dictionary<string, int>();

        public string ToRoman(int input) 
        {
            var result = new StringBuilder();
            
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

            return RomanLookup[input];
        }
    }
}
