using System.Linq;

public static class RotationalCipher
{
    private const int AlphabetSize = 26;

    public static string Rotate(string text, int shiftKey)
         => new string(text.Select(c => RotateChar(c, shiftKey)).ToArray());

    private static char RotateChar(char c, int key)
    {
        if (!char.IsLetter(c)) return c;

        var shift = char.IsLower(c) ? 'a' : 'A';
        return (char)(shift + (c - shift + key) % AlphabetSize);
    }
}