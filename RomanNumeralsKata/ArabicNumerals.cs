using System;
using System.Collections.Generic;

namespace RomanNumeralsKata
{
    public class ArabicNumerals
    {
        const int MaxRomanNumeral = 1;

        Dictionary<string, int> RomanLookup = new Dictionary<string, int>();

        public string ToRoman(int input) 
        {
            if (input == 2) return "II"; 
            return "I";
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
