using System.Collections.Generic;
using System.Linq;

internal static class DictionaryExtension
{
    /// <summary>
    /// Checks if both dictionaries contain same key-value pairs
    /// </summary>
    public static bool SameContents<Tkey, TValue>(this Dictionary<Tkey, TValue> d1, Dictionary<Tkey, TValue> d2)
        => d1.Count == d2.Count && !d1.Except(d2).Any();
}

public class Anagram
{
    private readonly Dictionary<char, int> baseDict;
    private readonly string baseWord;

    public Anagram(string word)
    {
        baseWord = word.ToLower();
        baseDict = CountLetters(baseWord);
    }

    public string[] FindAnagrams(string[] potentialMatches)
        => potentialMatches.Where(x => IsAnagramToBaseWord(x.ToLower())).ToArray();

    /// <summary>
    /// Checks if candidate is the anagram to base word. Word cannot be an anagram of itself.
    /// </summary>
    private bool IsAnagramToBaseWord(string candidate)
        => !candidate.Equals(baseWord) && baseDict.SameContents(CountLetters(candidate));

    /// <summary>
    /// Converts word to dictionary of letter:letter-quantity-in-word
    /// </summary>
    private Dictionary<char, int> CountLetters(string word)
        => word.GroupBy(x => x)
        .ToDictionary(group => group.Key, group => group.Count());
}