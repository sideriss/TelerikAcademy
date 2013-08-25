using System;
using System.Threading;
using System.Globalization;

class DayOfWeek
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime dateValue = DateTime.Today;
        Console.WriteLine(dateValue.ToString("dddd")); 
    }
}

