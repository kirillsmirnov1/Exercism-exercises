using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) => new string(
        phrase.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(FirstLetter)
            .Select(char.ToUpper)
            .ToArray()
    );

    private static char FirstLetter(string str)
        => str.First(char.IsLetter);
}