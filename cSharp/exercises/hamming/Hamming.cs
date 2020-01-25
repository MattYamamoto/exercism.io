using System;

public static class Hamming
{
  public static int Distance(string firstStrand, string secondStrand)
  {
    // Check if we are allowed to calculate Hamming distance.
    if (firstStrand.Length != secondStrand.Length)
    {
      throw new System.ArgumentException("Strands must be of equal length.");
    }

    // If strands are identical, there is no Hamming distance.
    if (firstStrand == secondStrand)
    {
      return 0;
    }

    // Calculate hamming distance.
    int dist = 0;
    for (int i = 0; i < firstStrand.Length; i++)
    {
      if (firstStrand[i] != secondStrand[i])
        dist++;
    }

    return dist;
  }
}