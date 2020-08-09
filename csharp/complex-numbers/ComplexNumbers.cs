using System;

public struct ComplexNumber
{
    private double r;
    private double i;

    public ComplexNumber(double real, double imaginary)
        => (r, i) = (real, imaginary);

    public double Real() => r;

    public double Imaginary() => i;

    public ComplexNumber Mul(ComplexNumber other)
        => new ComplexNumber(r * other.r - i * other.i, i * other.r + r * other.i);

    public ComplexNumber Add(ComplexNumber other)
        => new ComplexNumber(r + other.r, i + other.i);

    public ComplexNumber Sub(ComplexNumber other)
        => new ComplexNumber(r - other.r, i - other.i);

    public ComplexNumber Div(ComplexNumber other)
    {
        double d = other.r * other.r + other.i * other.i;
        return new ComplexNumber((r * other.r + i * other.i)/d, (i * other.r - r * other.i)/d);
    }

    public double Abs() => Math.Pow(r * r + i * i, 0.5);

    public ComplexNumber Conjugate() => new ComplexNumber(r, -i);

    public ComplexNumber Exp()
    {
        double ea = Math.Exp(r);
        return new ComplexNumber(ea * Math.Cos(i), ea * Math.Sin(i));
    }
}