using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (!ArgumentsOk(digits, span))
            throw new ArgumentException();

        var ints = digits.Select(num => num - '0');

        return Enumerable.Range(0, digits.Length - span + 1)
                  .Select
                  (
                      i => ints
                        .Skip(i)
                        .Take(span)
                        .Aggregate(1, (result, elem) => result * elem)
                  )
                  .Max();

    }
    private static bool ArgumentsOk(string digits, int span)
        => span <= digits.Length
        && span >= 0
        && digits.All(char.IsDigit);
}