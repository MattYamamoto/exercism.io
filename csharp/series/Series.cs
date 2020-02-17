using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0 || numbers.Length < sliceLength)
        {
            throw new ArgumentException();
        }

        string[] series = new string[numbers.Length - sliceLength + 1];
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            series[i] = numbers.Substring(i, sliceLength);
        }

        return series;
    }
}