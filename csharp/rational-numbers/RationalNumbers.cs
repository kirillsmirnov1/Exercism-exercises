using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
        => r.Expreal(realNumber);

    public static int Pow(this int number, int pow)
        => (int)Math.Pow(number, pow);
}

public struct RationalNumber
{
    private readonly int numerator;
    private readonly int denominator;

    public RationalNumber(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        => new RationalNumber(r1.numerator * r2.denominator + r2.numerator * r1.denominator, r1.denominator * r2.denominator).Reduce();

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        => new RationalNumber(r1.numerator * r2.denominator - r2.numerator * r1.denominator, r1.denominator * r2.denominator).Reduce();

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        => new RationalNumber(r1.numerator * r2.numerator, r1.denominator * r2.denominator).Reduce();

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        => new RationalNumber(r1.numerator * r2.denominator, r2.numerator * r1.denominator).Reduce();

    public RationalNumber Abs()
        => new RationalNumber(Math.Abs(numerator), Math.Abs(denominator));

    public RationalNumber Reduce()
    {
        int gcd = GCD(Abs());
        return new RationalNumber(Math.Sign(denominator) * numerator / gcd, Math.Abs(denominator) / gcd);
    }

    private int GCD(RationalNumber number)
        => GCD(number.numerator, number.denominator);

    private int GCD(int a, int b)
        => b == 0 ? a : a < b ? GCD(b, a) : GCD(b, a % b);

    public RationalNumber Exprational(int power)
        => power >= 0
        ? new RationalNumber(numerator.Pow(power), denominator.Pow(power))
        : new RationalNumber(denominator.Pow(-1 * power), denominator.Pow(-1 * power));

    public double Expreal(int baseNumber)
        => Math.Pow(baseNumber, numerator * 1d / denominator);
}