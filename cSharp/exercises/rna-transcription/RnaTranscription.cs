using System;
using System.Text;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        StringBuilder rna = new StringBuilder();
        Dictionary<string, string> translation = new Dictionary<string, string>();
        translation.Add("G", "C");
        translation.Add("C", "G");
        translation.Add("T", "A");
        translation.Add("A", "U");

        for (int i = 0; i < nucleotide.Length; i++)
        {
          string cur = translation[nucleotide.Substring(i, 1)];
          rna.Append(cur);
        }

        return rna.ToString();
    }

}