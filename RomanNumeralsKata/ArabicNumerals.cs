using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsKata
{
    public class ArabicNumerals
    {
        const int MaxRomanNumeral = 5;

        Dictionary<string, int> RomanLookup = new Dictionary<string, int>();

        public string ToRoman(int input) 
        {
            var result = new StringBuilder();
            if (input == 5) return "V";
            if (input == 4) return "IV";

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
