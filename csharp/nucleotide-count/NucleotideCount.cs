using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {

        int countA = 0;
        int countC = 0;
        int countG = 0;
        int countT = 0;

        for (int index = 0; index < sequence.Length; index++)
        {
            switch (sequence[index])
            {
                case 'A':
                    countA++;
                    break;

                case 'C':
                    countC++;
                    break;

                case 'G':
                    countG++;
                    break;

                case 'T':
                    countT++;
                    break;

                default:
                    throw new ArgumentException();
            }
        }

        IDictionary<char, int> counts = new Dictionary<char, int>(){
              {'A', countA}
            , {'C', countC}
            , {'G', countG}
            , {'T', countT}
        };

        return counts;
    }
}