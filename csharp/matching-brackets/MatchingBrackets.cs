using System.Collections.Generic;

public static class MatchingBrackets
{
    private static readonly Dictionary<char, char> Pairs = new Dictionary<char, char>
    {
        ['('] = ')',
        ['['] = ']',
        ['{'] = '}'
    };

    private static readonly HashSet<char> Closers = new HashSet<char> {')', ']', '}'};
    
    public static bool IsPaired(string input)
    {
        var q = new LinkedList<char>();
        
        foreach (var c in input.ToCharArray())
        {
            if (Pairs.ContainsKey(c))
            {
                q.AddLast(c);
            }
            else if (Closers.Contains(c))
            {
                if (q.Last != null && Pairs[q.Last.Value] == c)
                {
                    q.RemoveLast();
                }
                else
                {
                    return false;
                }
            }
        }

        return q.Count == 0;
    }
}
