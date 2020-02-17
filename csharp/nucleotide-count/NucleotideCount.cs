using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Regex re = new Regex(@"[^ACGT]");

        if (re.IsMatch(sequence)) throw new ArgumentException();

        IDictionary<char, int> counts = new Dictionary<char, int>(){
              {'A', sequence.Count(c => c == 'A')}
            , {'C', sequence.Count(c => c == 'C')}
            , {'G', sequence.Count(c => c == 'G')}
            , {'T', sequence.Count(c => c == 'T')}
        };

        return counts;
    }
}