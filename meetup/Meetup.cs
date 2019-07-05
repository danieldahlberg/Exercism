using System;

public enum Schedule
{
    Teenth = 13,
    First = 1,
    Second = 8,
    Third = 15,
    Fourth = 22,
    Last = 23 // We calculate this one on runtime
}

public class Meetup
{
    private int _month { get; set; }
    private int _year { get; set; }
    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var date = new DateTime(year: _year, month: _month, (int)schedule);
        int daysInWeek = 7;
        bool scheduleIsLastInMonth = false;
        if (schedule == Schedule.Last)
        {
            int daysInMonth = DateTime.DaysInMonth(_year, _month);
            date = new DateTime(year: _year, month: _month, daysInMonth);
            scheduleIsLastInMonth = true;
        }
        for (int i = 1; i <= daysInWeek; i++)
        {
            if (date.DayOfWeek != dayOfWeek)
                date = date.AddDays(scheduleIsLastInMonth ? -1 : 1);
        }
        return date;
    }

}