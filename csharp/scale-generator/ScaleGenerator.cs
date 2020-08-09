using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class ScaleGenerator
{
    private static readonly List<string> sharps = new List<string> { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
    private static readonly List<string> flats = new List<string> { "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab" };
    private static readonly string[] useFlats = new string[]{"F", "Bb", "Eb", "Ab", "Db", "Gb",
"d", "g", "c", "f", "bb", "eb"};

    public static string[] Chromatic(string tonic)
    {
        var scale = Scale(tonic);
        var start = scale.FindIndex(0, x => x.ToLower() == tonic.ToLower());

        return Enumerable.Range(start, 12)
            .Select(rawPos => rawPos >= 12 ? rawPos - 12 : rawPos)
            .Select(pos => scale[pos])
            .ToArray();
    }

    public static string[] Interval(string tonic, string pattern)
        => IntervalEnumerable(tonic, pattern).ToArray();

    private static IEnumerable<string> IntervalEnumerable(string tonic, string pattern)
    {
        var scale = Chromatic(tonic);
        int j = 0;
        foreach(char c in pattern)
        {
            yield return scale[j];
            j += Interval(c);
        }

        static int Interval(char c)
        {
            return c switch
            {
                'm' => 1,
                'M' => 2,
                'A' => 3,
                _ => throw new ArgumentException(),
            };
        }
    }

    private static List<string> Scale(string tonic) 
        => useFlats.Contains(tonic) ? flats : sharps;
}