using System;
using System.Collections;
using System.Text;

public static class House
{
    public static string[,] phrases = new string[12, 2] {
          {"house", "Jack built"}
        , {"malt", "lay in"}
        , {"rat", "ate"}
        , {"cat", "killed"}
        , {"dog", "worried"}
        , {"cow with the crumpled horn", "tossed"}
        , {"maiden all forlorn", "milked"}
        , {"man all tattered and torn", "kissed"}
        , {"priest all shaven and shorn", "married"}
        , {"rooster that crowed in the morn", "woke"}
        , {"farmer sowing his corn", "kept"}
        , {"horse and the hound and the horn", "belonged to"}
    };

    public static string Recite(int verseNumber)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("This is");
        sb.Append(GetPhrase(verseNumber));
        sb.Append(".");

        string verse = sb.ToString();

        return verse;
    }

    public static string GetPhrase(int verseNumber)
    {
        int phraseIndex = verseNumber - 1;

        if (phraseIndex < 0) return "";

        StringBuilder sb = new StringBuilder();

        sb.Append(" the ");
        sb.Append(phrases[phraseIndex, 0]);
        sb.Append(" that ");
        sb.Append(phrases[phraseIndex, 1]);
        sb.Append(GetPhrase(verseNumber - 1));

        string fullPhrase = sb.ToString();

        return fullPhrase;
    }

    public static string Recite(int startVerse, int endVerse)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = startVerse; i <= endVerse; i++)
        {
            sb.AppendLine(Recite(i));
        }

        string fullRhyme = sb.ToString().TrimEnd();

        return fullRhyme;
    }
}
