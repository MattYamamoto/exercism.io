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

        for (int i = verseNumber - 1; i >= 0; i--)
        {
            sb.Append(" the ");
            sb.Append(phrases[i, 0]);
            sb.Append(" that ");
            sb.Append(phrases[i, 1]);
        }

        sb.Append(".");

        string verse = sb.ToString();

        return verse;
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
