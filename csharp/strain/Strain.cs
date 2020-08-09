using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach(var elem in collection)
        {
            if(predicate(elem))
            {
                yield return elem;
            }
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        => collection.Keep(elem => !predicate(elem));
}