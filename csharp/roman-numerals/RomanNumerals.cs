using System;
using System.Collections.Generic;
using System.Linq;

public static class RomanNumeralExtension
{
    private static Dictionary<int, string[]> data = new Dictionary<int, string[]>
    { 
        [1]    = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" },
        [10]   = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" },
        [100]  = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" },
        [1000] = new string[] { "", "M", "MM", "MMM", }
    };
    public static string ToRoman(this int value)
        => value.ToString().Reverse()
        .Select((c, i) => data[(int)Math.Pow(10, i)][(int)char.GetNumericValue(c)])
        .Reverse()
        .Aggregate("", (a, b) => a + b);
}