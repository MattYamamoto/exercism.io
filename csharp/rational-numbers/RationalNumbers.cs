using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return r.Expreal(realNumber);
    }
}

public struct RationalNumber
{
    private readonly int numerator;
    private readonly int denominator;
    public RationalNumber(int numerator, int denominator)
    {

        bool isNegative = (numerator < 0) ^ (denominator < 0);

        this.numerator = (isNegative ? -1 : 1) * Math.Abs(numerator);
        this.denominator = Math.Abs(denominator);
    }

    public static int GreatestCommonDivsor(int num1, int num2)
    {
        if (num1 == 0 || num2 == 0)
        {
            return Math.Max(num1, num2);
        }

        int a = Math.Abs(num1);
        int b = Math.Abs(num2);
        int t;
        while (b != 0)
        {
            t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(
              r1.numerator * r2.denominator + r2.numerator * r1.denominator
            , r1.denominator * r2.denominator
            )
            .Reduce();
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(
              r1.numerator * r2.denominator - r2.numerator * r1.denominator
            , r1.denominator * r2.denominator
            )
            .Reduce();
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(
              r1.numerator * r2.numerator
            , r1.denominator * r2.denominator
            )
            .Reduce();
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(
              r1.numerator * r2.denominator
            , r1.denominator * r2.numerator
            )
            .Reduce();

    }

    public RationalNumber Abs()
    {
        return new RationalNumber(Math.Abs(this.numerator), Math.Abs(this.denominator));
    }

    public RationalNumber Reduce()
    {
        int gcd = GreatestCommonDivsor(numerator, denominator);

        int reducedNumerator = numerator / gcd;
        int reducedDenominator = denominator / gcd;

        return new RationalNumber(reducedNumerator, reducedDenominator);
    }

    public RationalNumber Exprational(int power)
    {
        return new RationalNumber(
              (int)Math.Pow(numerator, power)
            , (int)Math.Pow(denominator, power)
            )
            .Reduce();
    }

    public double Expreal(int baseNumber)
    {
        return Math.Pow(Math.Pow(baseNumber, numerator), 1.0 / denominator);
    }
}