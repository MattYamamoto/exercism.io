using System;
using System.Collections.Generic;

public class Robot
{
    public static HashSet<string> names = new HashSet<string>();

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
        Random r = new Random();

        int attempt = 1;
        string tryName = "";
        do
        {
            tryName = ((char)('A' + r.Next(0, 26))).ToString()
                + ((char)('A' + r.Next(0, 26))).ToString()
                + r.Next(0, 1000).ToString("D3");

            attempt++;

        } while (attempt < 26 * 26 * 1000 && names.Add(tryName));


    }
}