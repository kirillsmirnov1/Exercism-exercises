using System.Collections.Generic;
using System.Threading.Tasks;

public static class ParallelLetterFrequency
{
    private static Dictionary<char, int> d;
    private static readonly object _lock = new object();

    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        d = new Dictionary<char, int>();

        Parallel.ForEach(texts, text =>
            Parallel.ForEach(text.ToLower(), character =>
            {
                if (char.IsLetter(character))
                {
                    lock (_lock)
                    {
                        if (d.ContainsKey(character))
                            d[character]++;
                        else
                            d.Add(character, 1);
                    }
                }
            }
            ));

        return d;
    }
}