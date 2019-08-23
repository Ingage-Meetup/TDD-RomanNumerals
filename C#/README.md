# TDD-RomanNumerals: A C# Implementation

## Setup
I started by simply creating a VS Solution with two pprojects, [RomanNumerals.lib](./RomanNumerals.lib) containing the "library" code, and [RomanNumerals.test](./RomanNumerals.test)
containing the unit tests.  There is just one class in each, [RomanNumeralsConverter.cs](./RomanNumerals.lib/RomanNumeralsConverter.cs) in the library,
and [RomanNumeralsConverterTest.cs](./RomanNumerals.test/RomanNumeralsConverterTest.cs). I also looked for a page that more clearly laid out all the rules of Roman Numerals (I tried to avoid 
anything where a coding solution might be proposed). This site was a good reference: http://sierra.nmsu.edu/morandi/coursematerials/RomanNumerals.html

## Initial Converter Implementation
I added a method called `ConvertRomanNumeralsToArabic` in the converter class, and the initial implementation simply threw a NotImplementedException.
This was to enable me to start writing unit tests without getting a compiler error. It looked like this:
```csharp
using System;

namespace RomanNumerals.lib
{
    /// <summary>
    /// Convert Roman Numerals to Arabic, and Arabic to Roman Numerals.
    /// 
    /// Rules are well-defined on this page: http://sierra.nmsu.edu/morandi/coursematerials/RomanNumerals.html
    /// </summary>
    public class RomanNumeralsConverter
    {

        public int ConvertRomanNumeralsToArabic(string romanNumerals)
        {
            throw new NotImplementedException();
        }
    }
}
```

## Design Approach
After implementing the above, I then read all the rules more closely, and thought about how I might break the problem down, from the simplest use case of 
a single roman numeral, all the way to the largest possible roman numeral string (not using the multiplier bars), with all the validations that would 
eventually need to be done. As I thought through these, I added unit tests with descriptive names for each, in the order of how complex I thought each one would be
to implement. The idea was that I would go through the tests, in order, and implement code to just make the next test pass, refactoring along the way as needed.

Since the implementation above threw a NotImplementedException, all of the tests initially failed.

## Converter Implementation
I started out with a simple Dictionary, mapping a roman numeral character to the appropriate number. So to make the first test (`SingleRomanNumeralsShouldReturnProperIntegerValues`) pass,
I simply grabbed the first character from the given string (only one character in each string), looked up the value in the Dictionary, and returned the value.

To get the second test (`CertainRepeatedNumeralsShouldBeAdditive`) to pass, I built on the initial code, by looping over the roman numeral string, and summing up the value of each one.
Remember, I was building this incrementally, so my unit tests only sent valid input at each step along the way, or invalid input, if the expectation was that the converter should
handle the invalid input at that point. So at this point, there is NO error handling for too many repeated characters, characters that are not allowed to repeat, etc.

For the third test (`CertainNumeralsShouldSubtractFromNext`), I implemented the `LookAhead` function, and that is the first time I had any sort of validation at all - but it was out of
necessity to avoid runtim errors with valid input, not to solve any part of the business problem. This function returns the numeric value of the next character in the Roman Numeral
string, if there is a next character. Then in the converter function loop, the initial implementation subtracted the current value from the total if the next value was larger than the current value.
So now there's a little bit of logic, but still not a ton - and again, no error checking, so it would allow you to have subtractions like "VX", which is not valid.

At this point, the fourth test (`ManyValidRomanNumeralsShouldReturnProperValues`) also passed, even though I did not explicitly implement anything for it. This is because the code now handled
all of the basic rules assuming the input string was a valid Roman Numeral string.  Exciting!!

I won't go into the details of how I implemented all of the validation and error checking, because (I think...) the code is pretty straightforward for all of it. The only thing that I think was a 
little "clever" ("hard for the next dev to maintain") is how I handled checking for too many repeating characters (`CharactersShouldNotBeAllowedToRepeatMoreThanThreeTimes`) and 
invalid repeating characters (`CertainCharactersShouldNotBeAllowedToRepeat`).  There are several different ways I considered for those, but since I'm kind of old-school (where's my Perl??),
I went with regexes for these.

To check to make sure there are no characters repeated more than 3 times in a row, this regex did the trick: `(.)\1{3,}`.  I'll break that down:
1) `.` - matches any single character
2) `(.)` - a capturing group, so I can "save" the single character and reference it later
3) `\1` - this is now using the capturing group to do some matching
4) `{3,} - this says to look for the thing right before it (the capturing group), and match 3 or more occurrences in a row of that character

So this regex does not care about valid or invalid roman numeral characters, it is just making sure there is no single character repeated more than 3 times in a row. It would match `AAAA`, even though
`A` is not a valid roman numeral. So if we wanted better error reporting, we'd probably want to limit this to only the valid characters.  So maybe another refactor...

To check and make sure we don't repeat characters that shouldn't be repeated (V, L, and D), I used this regex: `([VLD])\1{1,}`.  That one is:
1) `[VLD]` - this says to look for any one character, V, L, or D
2) `([VLD])`- like above, this is a capturing group to save the match of the single V, L, or D
3) `\1` - this is now using the capturing group to do some matching
4) `{1,} - this says to look for the thing right before it (the capturing group), and match if there are more than one of those in a row

These two regexes could probably be combined into one really gnarly-looking check, or you could be a sane person and not use regexes in the first place...

## Summary
This was my first time implementing this kata, and it was definitely a good learning experience. The problem itself was not super-complicated, and there are only a handful of business rules.
Having done it once, I can see lots of ways to make this better, so I may create a branch and try some other solutions in my spare time.