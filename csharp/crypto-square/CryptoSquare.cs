using System;
using System.Collections.Generic;
using System.Linq;

public static class CryptoSquare
{
    public static string Ciphertext(string plaintext)
    {
        string filteredInput = Filter(plaintext);
        
        if (filteredInput.Length <= 1) return filteredInput;
        
        string oneLiner = AddSpaces(filteredInput, out int r, out int c);
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

    private static string AddSpaces(string characters, out int r, out int c)
    {
        c = (int)Math.Floor(Math.Sqrt(characters.Length));
        r = c;

        if (c * r < characters.Length) c++;
        if (c * r < characters.Length) r++;

        var spacesToAdd = r * c - characters.Length;
        
        return characters + new string(Enumerable.Repeat(' ', spacesToAdd).ToArray());
    }
    
    private static string Filter(string plainText) => 
        new string(plainText.ToLower().Where(char.IsLetterOrDigit).ToArray());
}