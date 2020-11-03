module RomanNumeralsFunctionsTests 

open NUnit.Framework
open RomanNumeralsKata.RomanNumeralsFunctions

type ArabicAndRomanValue = {
                                ArabicValue: int
                                RomanValue: string
                            }
let ArabicAndRomanValue a r = {
                                ArabicValue = a
                                RomanValue = r
                                }

let arabicAndRomanValues =
    seq {
        yield ArabicAndRomanValue 0 ""
        yield ArabicAndRomanValue 1 "I"
        yield ArabicAndRomanValue 3 "III"
        yield ArabicAndRomanValue 4 "IV"
        yield ArabicAndRomanValue 5 "V"
        yield ArabicAndRomanValue 6 "VI"
        yield ArabicAndRomanValue 8 "VIII"
        yield ArabicAndRomanValue 9 "IX"
        yield ArabicAndRomanValue 10 "X"
        yield ArabicAndRomanValue 11 "XI"
        yield ArabicAndRomanValue 14 "XIV"
        yield ArabicAndRomanValue 15 "XV"
        yield ArabicAndRomanValue 19 "XIX"
        yield ArabicAndRomanValue 20 "XX"
        yield ArabicAndRomanValue 30 "XXX"
        yield ArabicAndRomanValue 40 "XL"
        yield ArabicAndRomanValue 50 "L"
        yield ArabicAndRomanValue 60 "LX"
        yield ArabicAndRomanValue 100 "C"
        yield ArabicAndRomanValue 300 "CCC"
        yield ArabicAndRomanValue 500 "D"
        yield ArabicAndRomanValue 1000 "M"
        yield ArabicAndRomanValue 3000 "MMM"
    }

[<TestCaseSource("arabicAndRomanValues")>]
let RomanNumbers_GivenArabicValue_ReturnsCorrectRomanNumber({ArabicValue = a; RomanValue = r}) =
    let returnedValue = RomanNumerals a
    Assert.That(returnedValue,Is.EqualTo(r))