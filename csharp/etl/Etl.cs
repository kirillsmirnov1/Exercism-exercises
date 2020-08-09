using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
        => old
        .ToDictionary(kv => kv.Value, kv => kv.Key) // reverse to <string[], int>
        .Select(kvp => kvp.Key.ToDictionary(str => str.ToLower(), str => kvp.Value)) // select <string,int> dictionaries
        .SelectMany(x => x) // flatten dictionaries to KVPs
        .ToDictionary(x => x.Key, x => x.Value); // combine KVPs to single dictionary
}