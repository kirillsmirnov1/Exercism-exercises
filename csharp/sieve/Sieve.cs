using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2) throw new ArgumentOutOfRangeException();

        Dictionary<int, bool> dict = new Dictionary<int, bool>();

        for (int i = 2; i <= limit; ++i)
        {
            dict.Add(i, true);
        }

        for (int i = 2; i < limit; ++i)
        {
            if (dict[i])
            {
                for (int j = i * 2; j <= limit; j += i)
                {
                    dict[j] = false;
                }
            }
        }

        return dict.Where(pair => pair.Value).Select(pair => pair.Key).ToArray();

    }
}