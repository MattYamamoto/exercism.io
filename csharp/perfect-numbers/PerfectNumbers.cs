using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();

        int aliquotSum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                aliquotSum += i;
            }
        }

        return aliquotSum == number
            ? Classification.Perfect
            : aliquotSum > number
                ? Classification.Abundant
                : Classification.Deficient;
    }

}
