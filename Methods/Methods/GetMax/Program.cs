using System;

class Program
{
    static int GetMax(int min, int max)
    {
        if (min >= max)
        {
            max = min;
        }
        return max;
    }
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int bigger = GetMax(firstNumber, secondNumber);
        Console.WriteLine(GetMax(bigger,thirdNumber));
    }
}
