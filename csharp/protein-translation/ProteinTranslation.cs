using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    private static readonly Dictionary<string, string> rnaToProteins = new Dictionary<string, string>
    {
        ["AUG"] = "Methionine",
        ["UUU"] = "Phenylalanine",
        ["UUC"] = "Phenylalanine",
        ["UUA"] = "Leucine",
        ["UUG"] = "Leucine",
        ["UCU"] = "Serine",
        ["UCC"] = "Serine",
        ["UCA"] = "Serine",
        ["UCG"] = "Serine",
        ["UAU"] = "Tyrosine",
        ["UAC"] = "Tyrosine",
        ["UGU"] = "Cysteine",
        ["UGC"] = "Cysteine",
        ["UGG"] = "Tryptophan",
        ["UAA"] = "STOP",
        ["UAG"] = "STOP",
        ["UGA"] = "STOP",
    };

    private static readonly HashSet<string> stopCodes = new HashSet<string>
        { "UAA", "UAG", "UGA" };

    public static string[] Proteins(string strand)
        => Enumerable.Range(0, strand.Length/3)
        .Select(i => strand.Substring(i * 3, 3))
        .TakeWhile(str => !stopCodes.Contains(str))
        .Select(str => rnaToProteins[str])
        .ToArray();
}