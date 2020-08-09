using System;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
        => string.Concat(nucleotide.Select(x => CharToRna(x)));


    private static char CharToRna(char c)
        => c switch
        {
            'G' => 'C',
            'C' => 'G',
            'T' => 'A',
            'A' => 'U',
            _ => throw new ArgumentException()
        };
}