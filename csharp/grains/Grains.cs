using System;

public static class Grains
{
    public static ulong Square(int n)
        => (n > 0 && n < 65)
        ? 1UL << (n-1)
        : throw new ArgumentOutOfRangeException();


    public static ulong Total()
    {
        ulong sum = 0;
        ulong num = 1;

        for (int i = 0; i < 64; ++i)
        {
            sum += num;
            num *= 2;
        }

        return sum;
    }
}