using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {

        List<(int, int, int)> triplets = new List<(int, int, int)>();

        int a;
        int b;
        int c;

        for (a = 1; a < sum / 3; a++)
        {
            for (b = a; b < sum - (a + b); b++)
            {
                c = sum - (a + b);

                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    triplets.Add((a, b, c));
                }
            }
        }

        return triplets;
    }
}