using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> transformed = new Dictionary<string, int>();

        foreach (KeyValuePair<int, string[]> oldEntry in old)
        {
            foreach (string letter in oldEntry.Value)
            {
                transformed.Add(letter.ToLower(), oldEntry.Key);
            }
        }

        return transformed
            .OrderByDescending(KeyValuePair => KeyValuePair.Key)
            .ToDictionary(KeyValuePair => KeyValuePair.Key, KeyValuePair => KeyValuePair.Value);
    }
}