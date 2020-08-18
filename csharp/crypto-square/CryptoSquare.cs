using System;
using System.Collections.Generic;
using System.Linq;

public static class CryptoSquare
{
    public static string Ciphertext(string plaintext)
    {
        if (plaintext.Length == 0) return "";
        
        string oneLiner = ToOneliner(plaintext, out int r, out int c);
        char[][] charMatrix = ToCharMatrix(oneLiner, r, c);
        char[][] cipheredMatrix = CipherMatrix(charMatrix);
        
        return MatrixToString(cipheredMatrix);
    }

    private static string MatrixToString(char[][] cipheredMatrix)
        => string.Join(" ", cipheredMatrix.Select(x => new string(x)));

    private static char[][] CipherMatrix(char[][] charMatrix)
    {
        char[][] m = new char[charMatrix[0].Length][];
        for (int i = 0; i < m.Length; ++i)
        {
            m[i] = new char[charMatrix.Length];
        }

        for (int i = 0; i < charMatrix.Length; ++i)
        {
            for (int j = 0; j < charMatrix[0].Length; ++j)
            {
                m[j][i] = charMatrix[i][j];
            }
        }

        return m;
    }

    private static char[][] ToCharMatrix(string oneLiner, int r, int c)
        => Enumerable.Range(0, r)
            .Select(rowI => oneLiner.Substring(rowI * c, c).ToCharArray())
            .ToArray();

    private static string ToOneliner(string plainText, out int r, out int c)
    {
        string characters = new string(plainText.ToLower().Where(char.IsLetterOrDigit).ToArray());
        
        c = (int)Math.Floor(Math.Sqrt(characters.Length));
        r = c;

        if (c * r < characters.Length) c++;
        if (c * r < characters.Length) r++;
        
        return new string(
            Enumerable
                .Range(0, r * c - characters.Length)
                .Aggregate(characters, (a, b) => a + ' ')
                .ToArray());
    }
}