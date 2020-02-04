using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string cleanedWord = Regex.Replace(word, @"[\s-]", "");
        int distinctCount = new string(cleanedWord.ToUpper().Distinct().ToArray()).Length;

        return cleanedWord.Length == distinctCount;
    }
}
