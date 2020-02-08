using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> baseNumbers, int max)
    {

        return baseNumbers
            .SelectMany(n => allMultiples(n, max))
            .Distinct()
            .Sum();
    }

    public static IEnumerable<int> allMultiples(int baseNumber, int max)
    {
        IList<int> multiples = new List<int>();

        if (baseNumber == 0) return multiples;

        for (
            int multiple = baseNumber;
            multiple < max;
            multiple += baseNumber
        )
        {
            multiples.Add(multiple);
        }
        return multiples;
    }
}