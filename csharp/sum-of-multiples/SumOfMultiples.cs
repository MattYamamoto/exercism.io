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
        int multiple = baseNumber;
        IList<int> multiples = new List<int>();

        if (baseNumber == 0)
        {
            return multiples;
        }

        while (multiple < max)
        {
            multiples.Add(multiple);

            multiple += baseNumber;
        }
        return multiples;
    }
}