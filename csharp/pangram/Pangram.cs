using System;
using System.Linq;

public static class Pangram
{
  public static bool IsPangram(string input)
  {
    if (string.IsNullOrEmpty(input))
    {
      return false;
    }

    const string alphabet = "abcdefghijklmnopqrstuvwxyz";

    return alphabet.All(input.ToLower().Contains);
  }
}
