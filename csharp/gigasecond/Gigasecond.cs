using System;

public static class Gigasecond
{
    private const double gigasecond = 1_000_000_000;
    public static DateTime Add(DateTime moment)
        => moment.AddSeconds(gigasecond);
}