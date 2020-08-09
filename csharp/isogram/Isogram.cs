using System;
using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = new string(word.ToLower().Where(char.IsLetter).ToArray());
        return word.Distinct().Count() == word.Length;
    }
}
