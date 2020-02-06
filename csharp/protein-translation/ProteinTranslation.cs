using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static IDictionary<string, string> peptides = new Dictionary<string, string>() {
          {"AUG", "Methionine"}
        , {"UUU", "Phenylalanine"}
        , {"UUC", "Phenylalanine"}
        , {"UUA", "Leucine"}
        , {"UUG", "Leucine"}
        , {"UCU", "Serine"}
        , {"UCC", "Serine"}
        , {"UCA", "Serine"}
        , {"UCG", "Serine"}
        , {"UAU", "Tyrosine"}
        , {"UAC", "Tyrosine"}
        , {"UGU", "Cysteine"}
        , {"UGC", "Cysteine"}
        , {"UGG", "Tryptophan"}
        , {"UAA", ""}
        , {"UAG", ""}
        , {"UGA", ""}
    };
    public static string[] Proteins(string strand)
    {
        var translation = new List<string>();

        for (int i = 0; i < strand.Length; i += 3)
        {
            string codon = strand.Substring(i, 3);
            string peptide = peptides[codon];
            if (String.IsNullOrEmpty(peptide))
            {
                break;
            }

            translation.Add(peptide);
        }
        return translation.ToArray();
    }
}