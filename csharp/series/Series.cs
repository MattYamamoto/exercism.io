using System;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0 || numbers.Length < sliceLength)
        {
            throw new ArgumentException();
        }

        int totalSlices = numbers.Length - sliceLength + 1;

        string[] series = Enumerable.Range(0, totalSlices)
            .Select(sliceStart => numbers.Substring(sliceStart, sliceLength))
            .ToArray();

        return series;
    }
}