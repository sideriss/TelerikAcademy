using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter year : ");
        string years = Console.ReadLine();
        int year;
        if (int.TryParse(years,out year))
        {
            if (year < 0)
            {
                Console.WriteLine("Invalid year");
                return;
            }
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year {0} is leap -- > YES",year);
            }
            else if (DateTime.IsLeapYear(year) == false)
            {
                Console.WriteLine("The year {0} is not leap -- > NO", year);
            }
        }
        else
        {
            Console.WriteLine("Invalid year");
        }
    }
}
