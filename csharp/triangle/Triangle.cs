using System;

public static class Triangle
{
    public static bool IsScalene(double a, double b, double c)
        => IsTriangle(a, b, c) && !IsIsosceles(a, b, c);

    public static bool IsIsosceles(double a, double b, double c)
        => IsTriangle(a, b, c) && (a == b || a == c || b == c);

    public static bool IsEquilateral(double a, double b, double c)
        => ZeroCheck(a, b, c) && a == b && b == c;

    private static bool ZeroCheck(double a, double b, double c)
        => a != 0d && b != 0d && c != 0d; 

    private static bool IsTriangle(double a, double b, double c)
        => a + b >= c
        && a + c >= b
        && b + c >= a;
}