using System;

class Program
{
    static void Main()
    {
        string decimalNumber = Console.ReadLine();
        int number = int.Parse(decimalNumber);
        string hex = number.ToString("X");
        Console.WriteLine(hex);
    }
}

