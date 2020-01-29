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
  private int year;
  private int month;
  private int day;
  public Meetup(int month, int year)
  {
    this.month = month;
    this.year = year;
  }

  public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
  {

    int step = 1;

    switch (schedule)
    {
      case Schedule.Teenth:
        day = 13;
        break;

      case Schedule.First:
        day = 1;
        break;

      case Schedule.Second:
        day = 8;
        break;

      case Schedule.Third:
        day = 15;
        break;

      case Schedule.Fourth:
        day = 22;
        break;

      case Schedule.Last:
        day = DateTime.DaysInMonth(year, month);
        step = -1;
        break;

      default:
        day = 1;
        break;

    }

    DateTime meetupDate = new DateTime(year, month, day);

    while (meetupDate.DayOfWeek != dayOfWeek)
    {
      meetupDate = meetupDate.AddDays(step);
    }

    return meetupDate;
  }
}