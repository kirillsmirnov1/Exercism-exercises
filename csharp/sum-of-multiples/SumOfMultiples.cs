using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{

    public static int Sum(IEnumerable<int> multiples, int max)
        => Enumerable.Range(0, max).Where(i => multiples.Any(multiple => multiple > 0 && i % multiple == 0)).Sum();
}