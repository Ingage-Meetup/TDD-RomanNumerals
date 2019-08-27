using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralsKata
{
    public class ArabicNumerals
    {
        const int MaxRomanNumeral = 3899;

        static Dictionary<string, int> RomanLookup = new Dictionary<string, int>();
        static Dictionary<int, string> ArabicLookup = new Dictionary<int, string>();

        public int FromRoman(string input)
        {
            input = input.ToUpper();
            if (RomanLookup.ContainsKey(input) == false)
            {
                throw new ArgumentException($"Value {input} is not a valid roman numeral");
            }

            return RomanLookup[input];
        }

        public string ToRoman(int input)
        {
            if (input < 1 || input > MaxRomanNumeral)
            {
                throw new ArgumentOutOfRangeException($"Value must be between 1 and {MaxRomanNumeral}");
            }

            return ArabicLookup[input];
        }

        private static RomanNumeralMapper GetSubtrator(List<RomanNumeralMapper> mappers, RomanNumeralMapper currentMapper)
        {
            if (currentMapper.SubtractorRoman == '\0')
            {
                return null;
            }

            foreach (var mapper in mappers)
            {
                if (mapper.Roman == currentMapper.SubtractorRoman)
                {
                    return mapper;
                }
            }

            return null;
        }

        private static string GenerateRoman(List<RomanNumeralMapper> mappers, int arabic)
        {
            var result = new StringBuilder();

            foreach (var mapper in mappers)
            {
                if (arabic == 0) 
                {
                    // Exit out early since we already have exact value 
                    break;
                }

                // Handle repeatable single character
                while (arabic >= mapper.Arabic)
                {
                    arabic -= mapper.Arabic;
                    result.Append(mapper.Roman);
                }

                // Handle multi-character subtraction
                var subtractor = GetSubtrator(mappers, mapper);
                if (subtractor != null)
                {
                    var value = mapper.Arabic - subtractor.Arabic;
                    if (arabic >= value)
                    {
                        arabic -= value;
                        result.Append(subtractor.Roman);
                        result.Append(mapper.Roman);
                    }
                }
            }

            return result.ToString();
        }

        static ArabicNumerals()
        {
            var romanValues = new List<RomanNumeralMapper>
            {
                new RomanNumeralMapper{Roman = 'M', Arabic = 1000, SubtractorRoman = 'C'},
                new RomanNumeralMapper{Roman = 'D', Arabic = 500, SubtractorRoman = 'C'},
                new RomanNumeralMapper{Roman = 'C', Arabic = 100, SubtractorRoman = 'X'},
                new RomanNumeralMapper{Roman = 'L', Arabic = 50, SubtractorRoman = 'X'},
                new RomanNumeralMapper{Roman = 'X', Arabic = 10, SubtractorRoman = 'I'},
                new RomanNumeralMapper{Roman = 'V', Arabic = 5, SubtractorRoman = 'I'},
                new RomanNumeralMapper{Roman = 'I', Arabic = 1}
            };

            for (int arabic = 1; arabic <= MaxRomanNumeral; arabic++)
            {
                var roman = GenerateRoman(romanValues, arabic);
                RomanLookup[roman] = arabic;
                ArabicLookup[arabic] = roman;
            }
        }
    }
}
