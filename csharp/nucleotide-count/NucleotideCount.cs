using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        if(!sequence.All("ACGT".Contains))
        {
            throw new ArgumentException();
        }

        return ("ACGT" + sequence)
            .GroupBy(ch => ch)
            .ToDictionary(group => group.Key, group => group.Count() - 1);
    }
}