using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> scores;

    public HighScores(List<int> list) => scores = list;

    public List<int> Scores() => scores;

    public int Latest() => scores.LastOrDefault();

    public int PersonalBest() => scores.Count == 0 ? 0 : scores.Max();

    public List<int> PersonalTopThree()
        => scores.OrderByDescending(i => i).Take(3).ToList();
}