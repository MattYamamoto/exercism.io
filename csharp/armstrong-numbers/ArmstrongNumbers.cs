using System;
using System.Linq;

public static class ArmstrongNumbers
{
  public static bool IsArmstrongNumber(int number)
  {
    string num = number.ToString();
    double digitCount = num.Length;

    var possibleArmstrong = num.Aggregate(0, (sum, c) => sum + (int)Math.Pow(double.Parse(c.ToString()), digitCount));

    return possibleArmstrong == number;
  }
}