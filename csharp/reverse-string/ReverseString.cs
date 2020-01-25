using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] inputArr = input.ToCharArray();
        Array.Reverse(inputArr);

        return new string(inputArr);
    }
}