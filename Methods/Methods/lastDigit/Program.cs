using System;

class Program
{
    static int lastNumber(int lastDigit, int number)
    {
        lastDigit = number % 10;
        return lastDigit;
    }
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Last digit is : "+ lastNumber(0,number));
    }
}

