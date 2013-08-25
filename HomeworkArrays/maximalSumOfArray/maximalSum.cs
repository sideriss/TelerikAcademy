//Write a program that reads two integer numbers N and K and an array 
//of N elements from the console. Find in the array those K elements that have maximal sum.

using System;

class maximalSum 
{
    static void Main()
    {
        Console.Write("Massive' s length = ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int bigSum = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter element [{0}] = ", i);
            int elements = int.Parse(Console.ReadLine());
            array[i] = elements;
        }
        Console.Write("How much elements we will check?  =  ");
        int K = int.Parse(Console.ReadLine());
        int sum = 0;
        Array.Sort(array);
        Console.WriteLine("Elements are : ");
        for (int i = 0; i < K; i++)
        {
            if (i < K - 1)
            {
                sum = sum + array[N - i - 1];
                Console.Write("{0} , ", array[N - i - 1]);
            }
            if (i == K - 1)
            {
                sum = sum + array[N - i - 1];
                Console.Write("{0}", array[N - i - 1]); 
            }
        }
        Console.WriteLine();
        Console.WriteLine("Maximum sum of {0} elements of this array is {1}", K, sum);
    }
}

