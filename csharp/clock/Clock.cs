using System;

#nullable enable

public class Clock : IEquatable<Clock>
{
    private readonly int _hours;
    private readonly int _minutes;

    public Clock(int hours, int minutes) => (_hours, _minutes) = Calibrate(hours, minutes);

    public Clock Add(int minutesToAdd) => new Clock(_hours, _minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(_hours, _minutes - minutesToSubtract);

    private static Tuple<int, int> Calibrate(int hours, int minutes)
    {
        if (minutes < 0)
        {
            var hoursDiff = minutes / 60 - 1;
            minutes -= hoursDiff * 60;
            hours += hoursDiff;
        }
        
        // It's not else-if to handle 00:60
        // Which we'll get, if input minutes are -60 * x
        if (minutes >= 60) 
        {
            hours += Math.DivRem(minutes, 60, out int remainder);
            minutes = remainder;
        }
        
        if (hours < 0)
        {
            hours -= 24 * (hours / 24 - 1);
        }

        // Same here
        if (hours >= 24)
        {
            hours %= 24;
        }

        return Tuple.Create(hours, minutes);
    }

    public override string ToString() => $"{_hours:D2}:{_minutes:D2}";

    public bool Equals(Clock other) => other != null && other._hours == _hours && other._minutes == _minutes;

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (!(obj is Clock)) return false;

        var other = (Clock) obj;

        return other._hours == _hours && other._minutes == _minutes;
    }

    public override int GetHashCode() => _minutes + 60 * _hours;
}
