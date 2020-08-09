using System.Linq;

public static class Pangram
{
    // It might be easier to copypaste letters, but I'm not looking for easy ways
    private static readonly string alphabet = string.Concat(Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToList());

    public static bool IsPangram(string text)
     => alphabet.All(a => text.ToLower().Contains(a));
}
