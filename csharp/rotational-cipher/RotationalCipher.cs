using System.Linq;

public static class RotationalCipher
{
    private const int AlphabetSize = 26;

    public static string Rotate(string text, int shiftKey)
         => new string(text.Select(c => RotateChar(c, shiftKey)).ToArray());

    private static char RotateChar(char c, int key)
    {
        if (c >= 'a' && c <= 'z')
        {
            return (char)('a' + RotateInt(c - 'a', key));
        }

        if (c >= 'A' && c <= 'Z')
        {
            return (char)('A' + RotateInt(c - 'A', key));
        }

        return c;
    }

    private static int RotateInt(int c, int key) => (c + key) % AlphabetSize;
}