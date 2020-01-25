using System;

public static class Pangram
{
  public static bool IsPangram(string input)
  {
    if (string.IsNullOrEmpty(input))
    {
      return false;
    }

    char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    string parsedInput = input.ToLower();

    foreach (char c in alphabet)
    {
      if (parsedInput.IndexOf(c) < 0)
      {
        return false;
      }
    }

    return true;
  }
}
