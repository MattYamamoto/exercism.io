using System;
using System.Linq;
using System.Text.RegularExpressions;


public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string pattern = @"[^A-Za-z']([A-Za-z])";
        Regex re = new Regex(pattern);

        var startLetters = re.Matches(" " + phrase)
                .Cast<Match>()
                .Select(m => m.Groups[1].Value)
                .ToArray();

        return String.Join("", startLetters).ToUpper();
    }
}