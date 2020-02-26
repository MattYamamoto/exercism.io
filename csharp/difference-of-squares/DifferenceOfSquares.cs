using System;
using System.Collections.Generic;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = Enumerable.Range(1, max)
            .Aggregate(0, (runningTotal, currentNumber) => runningTotal + currentNumber);

        return sum * sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        List<int> squares = Enumerable.Range(1, max)
            .Select(currentNumber => currentNumber * currentNumber).ToList();

        return squares.Aggregate(0, (runningTotal, currentNumber) => runningTotal + currentNumber);
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);

}