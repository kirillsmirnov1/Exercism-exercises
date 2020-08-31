using System.Collections.Generic;

public static class MatchingBrackets
{
    private static readonly Dictionary<char, char> Pairs = new Dictionary<char, char>
    {
        ['('] = ')',
        ['['] = ']',
        ['{'] = '}'
    };

    private static readonly HashSet<char> Closers = new HashSet<char>(Pairs.Values);
    
    public static bool IsPaired(string input)
    {
        var q = new Stack<char>();
        
        foreach (var c in input.ToCharArray())
        {
            if (Pairs.ContainsKey(c))
            {
                q.Push(c);
            }
            else if (Closers.Contains(c))
            {
                if (!q.TryPop(out char pop) || Pairs[pop] != c)
                {
                    return false;
                }
            }
        }

        return q.Count == 0;
    }
}
