using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private readonly int year;
    private readonly int month;

    public Meetup(int month, int year)
    {
        this.year = year;
        this.month = month;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        DateTime date = new DateTime(year, month,
            schedule switch
            {
                Schedule.First => 1,
                Schedule.Second => 8,
                Schedule.Third => 15,
                Schedule.Fourth => 22,
                Schedule.Last => DateTime.DaysInMonth(year, month) - 6,
                Schedule.Teenth => 13,
                _ => throw new ArgumentOutOfRangeException()
            }); 

        int daysFromRequiredDayOfWeek = (7 + dayOfWeek - date.DayOfWeek) % 7; 
        date = date.AddDays(daysFromRequiredDayOfWeek);

        return date;
    }
}