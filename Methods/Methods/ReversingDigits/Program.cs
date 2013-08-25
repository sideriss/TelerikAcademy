using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void ReverseTheDigits(decimal number)
    {
        string reversed = number.ToString();

        char[] charArray = reversed.ToCharArray();
        Array.Reverse(charArray);
        new string(charArray);
        Console.WriteLine(charArray);
    }


    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Write a decimal number for convertion:");
        decimal number = decimal.Parse(Console.ReadLine());
        ReverseTheDigits(number);
    }
}

