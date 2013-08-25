using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter number : ");
        string number = Console.ReadLine();
        int num = int.Parse(number);
        List<int> massive = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            int divider = num % 2;
            massive.Add(divider);
            num /= 2;
            if (num == 0)
            {
                break;
            }
        }
        massive.Reverse();
        foreach (var item in massive)
        {
            Console.WriteLine(item);
        }
    }
}

