using System;
using System.Collections.Generic;
using System.Linq;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
        => (inputBase < 2 || outputBase < 2 || inputDigits.Any(digit => digit < 0 || digit >= inputBase))
        ? throw new ArgumentException()
        : FromBase10(ToBase10(inputBase, inputDigits), outputBase);

    public static int ToBase10(int inputBase, int[] inputDigits)
        => inputDigits
        .Reverse()
        .Select((x, i) => x * (int)Math.Pow(inputBase, i))
        .Sum();

    private static int[] FromBase10(int number, int outputBase)
        => (number == 0)
        ? new[] { 0 }
        : GenerateDividents(number, outputBase)
            .Select(divident => divident % outputBase)
            .Reverse()
            .ToArray();

    private static IEnumerable<int> GenerateDividents(int number, int outputBase)
    {
        while (number > 0)
        {
            yield return number;
            number /= outputBase;
        }
    }
}