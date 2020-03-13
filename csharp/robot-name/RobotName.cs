using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    public static List<int> names;

    private Random random = new Random();

    private string _name;

    public string Name
    {
        get
        {
            if (String.IsNullOrEmpty(_name))
            {
                Reset();
            }
            return _name;
        }
    }

    public Robot()
    {
        // Only initialize once
        if (names == null)
        {
            names = Enumerable.Range(0, 26 * 26 * 1000 - 1).ToList();
        }
    }

    public void Reset()
    {
        if (names.Count == 0)
        {
            throw new NoMoreRobotsAvailable();
        }

        string oldName = _name;

        int index = random.Next(0, names.Count);
        _name = NameFromInt(names[index]);
        names.RemoveAt(index);

        // Allow old name re-use for future robots.
        if (!String.IsNullOrEmpty(oldName))
        {
            names.Add(IntFromName(oldName));
        }

    }

    private string NameFromInt(int nameValue)
    {
        int firstCharacterValue = (int)Math.Floor(nameValue / 26000d);
        int secondCharacterValue = (int)Math.Floor((nameValue % 26000) / 1000d);

        char firstChar = (char)('A' + firstCharacterValue);
        char secondChar = (char)('A' + secondCharacterValue);

        string name = firstChar.ToString()
                    + secondChar.ToString()
                    + (nameValue % 1000).ToString("D3");

        return name;
    }

    private int IntFromName(string name)
    {
        int nameValue = (int)(name[0] - 'A') * 26000
                      + (int)(name[1] - 'A') * 1000
                      + Int32.Parse(name.Substring(2, 3));

        return nameValue;
    }
}

public class NoMoreRobotsAvailable : Exception
{
    public NoMoreRobotsAvailable()
    {
    }
}