using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (digits.Length < span
            || span < 0
            || !digits.All(Char.IsDigit)
           )
        {
            throw new ArgumentException();
        }

        long maxProduct = 0;
        long product;
        for (int i = 0; i <= digits.Length - span; i++)
        {
            product = GetProduct(digits.Substring(i, span));
            maxProduct = Math.Max(product, maxProduct);
        }

        return maxProduct;
    }

    public static long GetProduct(string digits)
    {
        long product = digits.Aggregate(1L, (p, c) =>
        {
            p *= (long)Char.GetNumericValue(c);
            return p;
        });

        return product;
    }
}