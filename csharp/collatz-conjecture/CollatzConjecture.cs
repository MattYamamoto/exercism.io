using System;

public static class CollatzConjecture
{
  public static int Steps(int number)
  {
    if (number <= 0)
    {
      throw new ArgumentException("Argument must be a positive integer");
    }

    if (number == 1)
    {
      return 0;
    }

    int nextNumber = number % 2 == 0 ? number / 2 : 3 * number + 1;

    return Steps(nextNumber) + 1;
  }
}