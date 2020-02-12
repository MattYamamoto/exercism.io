using System;

public struct ComplexNumber
{
    double _real;
    double _imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        _real = real;
        _imaginary = imaginary;
    }

    public double Real()
    {
        return _real;
    }

    public double Imaginary()
    {
        return _imaginary;
    }

    public ComplexNumber Mul(ComplexNumber other)
    {
        return new ComplexNumber(
              (_real * other.Real() - _imaginary * other.Imaginary())
            , (_imaginary * other.Real() + _real * other.Imaginary())
            );
    }

    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber((_real + other.Real()), (_imaginary + other.Imaginary()));
    }

    public ComplexNumber Sub(ComplexNumber other)
    {
        return new ComplexNumber((_real - other.Real()), (_imaginary - other.Imaginary()));
    }

    public ComplexNumber Div(ComplexNumber other)
    {
        double real = (_real * other.Real() + _imaginary * other.Imaginary())
          / (Math.Pow(other.Real(), 2) + Math.Pow(other.Imaginary(), 2));

        double imaginary = (_imaginary * other.Real() - _real * other.Imaginary())
          / (Math.Pow(other.Real(), 2) + Math.Pow(other.Imaginary(), 2));

        return new ComplexNumber(real, imaginary);
    }

    public double Abs()
    {
        return Math.Sqrt(Math.Pow(_real, 2) + Math.Pow(_imaginary, 2));
    }

    public ComplexNumber Conjugate()
    {
        return new ComplexNumber(_real, -1 * _imaginary);
    }

    public ComplexNumber Exp()
    {
        double realExp = Math.Exp(_real);
        return new ComplexNumber(realExp * Math.Cos(_imaginary), realExp * Math.Sin(_imaginary));
    }
}