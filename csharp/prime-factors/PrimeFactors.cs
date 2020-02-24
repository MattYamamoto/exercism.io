using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {

        List<long> factors = new List<long>();

        long divisor = number;
        long factor = 2;

        while (divisor != 1)
        {
            if (divisor % factor == 0)
            {
                factors.Add(factor);
                divisor /= factor;
            }
            else
            {
                factor++;
            }
        }

        return factors.ToArray();
    }
}