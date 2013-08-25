using System;
using System.Threading;
using System.Globalization;

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
    static double AverageSum(int[] averageSum, int length)
    {
        int average = 0;
        for (int i = 0; i < averageSum.Length; i++)
        {
            average += averageSum[i];
        }
        average /= length;
        return average;
    }
    static int SolvingEquasion(int a, int b, int c)
    {

        int discriminant = (b * b) - (4 * (a * c));                      // finding discriminant by formula and print the result
        Console.WriteLine("Discriminant is : {0}", discriminant);
        int x, x1, x2;
        int zero = 0;
        if (discriminant == 0)                                              // conditions
        {                                                                   //for double root 
            Console.WriteLine("The equasion has ONE Double root!");
            x = (b * (-1)) / (2 * a);
            Console.WriteLine("The Double root is : {0}", x);
            return x;
        }
        else if (discriminant < 0)                                 // no roots 
        {
            Console.WriteLine("The equasion has NO roots!");
            return zero;
        }
        else if (discriminant != 0 && discriminant > 0)                      // two roots
        {
            x1 = ((b * (-1)) + (int)Math.Sqrt(discriminant)) / 2;
            x2 = ((b * (-1)) - (int)Math.Sqrt(discriminant)) / 2;
            Console.WriteLine("The first root is : {0}", x1);
            Console.WriteLine("The second root is : {0}", x2);
            string roots = x1.ToString() + " " + x2.ToString();
            int rootsnum = int.Parse(roots);
            return rootsnum;
        }
        else
        {
            return zero;
        }
    }
    static void Main()
    {
        Console.WriteLine("1. Enter [1] for Reversing the number digits");
        Console.WriteLine("2. Enter [2] for Calcularing the average sum");
        Console.WriteLine("3. Enter [3] for solving a linear equation");
        int userImput;
        do
        {
            userImput = int.Parse(Console.ReadLine());
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            if (userImput == 1)
            {
                Console.Clear();
                Console.Write("Write a decimal number for convertion : ");
                decimal number = decimal.Parse(Console.ReadLine());
                Console.Write("The new number is : ");
                ReverseTheDigits(number);
                return;
            }
            if (userImput == 2)
            {
                Console.Write("How much numbers you want to check : ");
                int length = int.Parse(Console.ReadLine());
                int[] numbers = new int[length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("Enter the {0} digit : ", (i + 1));
                    int digit = int.Parse(Console.ReadLine());
                    numbers[i] = digit;
                }
                Console.WriteLine("Average Number = " + AverageSum(numbers, length));
                return;

            }
            if (userImput == 3)
            {
                Console.Write("Give me a : ");
                int a = int.Parse(Console.ReadLine());                              //declaring a, b , c
                while (a == 0 || a < 0)
                {

                    if (a == 0 || a < 0)                                           //making sure that the (a) are not 0 or negative
                    {                                                         // and loops us back to enter value of (a)
                        Console.WriteLine("Number can be > 0 ! Try again");
                        Console.Write("Give me a : ");
                        a = int.Parse(Console.ReadLine());
                    }
                }
                Console.Write("Give me b : ");                                   // declaring the other values
                int b = int.Parse(Console.ReadLine());
                Console.Write("Give me c : ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("Result" + SolvingEquasion(a, b, c));
                return;
            }
            else
            {
                Console.WriteLine("Wrong imput - The imput must be 1, 2 or 3... Try again");
            }
        }
        while (userImput != 1 || userImput != 2 || userImput != 3);
    }
}

