using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
        => subjects.Length == 0
        ? new string[0]
        : subjects.Zip(subjects.Skip(1),
            (a, b) => $"For want of a {a} the {b} was lost.")
        .Append($"And all for the want of a {subjects[0]}.")
        .ToArray();
}