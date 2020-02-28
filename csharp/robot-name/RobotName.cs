using System;
using System.Collections.Generic;
using System.Threading;

public class Robot
{
    public static HashSet<string> names = new HashSet<string>();

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

    public void Reset()
    {

        int attempt = 0;
        bool isUniqueName;
        string tryName = "";
        do
        {
            tryName = randomLetters(2) + randomNumericString(3);
            isUniqueName = names.Add(tryName);

            attempt++;

        } while (attempt < 26 * 26 * 1000 && !isUniqueName);

        _name = tryName;
    }

    private string randomLetters(int numberOfLetters)
    {
        string letters = "";

        for (int i = 0; i < numberOfLetters; i++)
        {
            letters += ((char)('A' + random.Next(0, 26))).ToString();
        }

        return letters;
    }

    private string randomNumericString(int digits)
    {
        return random.Next(0, (int)Math.Pow(10, digits)).ToString("D" + digits.ToString());
    }
}