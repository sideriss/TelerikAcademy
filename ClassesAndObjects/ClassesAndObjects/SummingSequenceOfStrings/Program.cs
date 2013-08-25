using System;

class Program
{
    static void Main()
    {
        string[] sequence = Console.ReadLine().Split(' ');
        int value;
        int sum = 0;
        foreach (var item in sequence)
        {
            value = int.Parse(item);
            sum += value;
        }
        Console.WriteLine("Sum is : "+ sum);
    }
}