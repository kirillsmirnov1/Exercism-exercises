using System;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
        => DataIsOkay(numbers, sliceLength) 
        ? Enumerable.Range(0, numbers.Length - sliceLength + 1)
            .Select(i => numbers.Substring(i, sliceLength))
            .ToArray()
        : throw new ArgumentException();

    private static bool DataIsOkay(string numbers, int sliceLength)
        => sliceLength > 0
        && sliceLength <= numbers.Length;
}