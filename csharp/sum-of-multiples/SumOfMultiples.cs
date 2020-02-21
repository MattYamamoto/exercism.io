using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> baseNumbers, int max)
    {

        return (int)baseNumbers
            .SelectMany(n => allMultiples(n, max))
            .Distinct()
            .Sum();
    }

    public static IEnumerable<long> allMultiples(int baseNumber, int max)
    {
        IList<long> multiples = new List<long>();

        if (baseNumber == 0) return multiples;


        for (
            long multiple = baseNumber;
            multiple < max;
            multiple += baseNumber
        )
        {
            multiples.Add(multiple);
        }

        return multiples;
    }
}