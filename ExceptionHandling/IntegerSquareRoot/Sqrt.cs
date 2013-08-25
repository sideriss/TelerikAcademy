using System;

class Sqrt
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number : ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                throw new FormatException();
            }
            double sqrt = Math.Sqrt(number);
            Console.WriteLine("SQRT : "+sqrt);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye !!!");
        }
    }
}
