using System;

public class NumberOfWorkDays
{
    public static void Main()
    {
        
        Console.WriteLine("Enter a end date in YYYY    MM    DD format");

        Console.Write("Enter year : ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter month : ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter day : ");
        int day = int.Parse(Console.ReadLine());

        
        DateTime startDay = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        int timeLen = 0;
        timeLen = Math.Abs((endDay - startDay).Days);
        if (startDay > endDay)
        {
            startDay = endDay;
            endDay = DateTime.Today;
        }

        // Holydays
        DateTime[] holidays =
        {
            new DateTime(2013, 1, 1),
            new DateTime(2012, 2, 2),
            new DateTime(2012, 3, 3),
            new DateTime(2012, 4, 4),
            new DateTime(2013, 1, 18)
        };
        Console.WriteLine("Total days : "+timeLen);
        int workDayCounter = 0;
        bool isHoliday = false;

        // Day checker
        for (int i = 0; i < timeLen; i++)
        {
            startDay = startDay.AddDays(1);
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (startDay == holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDayCounter++;
                }

                isHoliday = false;
            }
        }

        Console.WriteLine("Working days : "+workDayCounter);
    }
}