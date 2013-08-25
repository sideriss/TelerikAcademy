using System;

class ReadNumber
{
    static void Main()
    {
        try
        {
            Console.Write("Enter lower bound : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter upper bound : ");
            int end = int.Parse(Console.ReadLine());
            ReadNumbers(start, end);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of lower and upper bound !");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer !");
        }
    }
    static void ReadNumbers(int start, int end)
    {
        Console.Write("Enter how much numbers you will imput : ");
        int numberOfIntegers = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfIntegers; i++)
        {
            Console.Write("Enter [{0}] number between [{1}] and [{2}] : ", i + 1,start,end);
            int num = int.Parse(Console.ReadLine());
            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            start = num;
        }
        
    }
}