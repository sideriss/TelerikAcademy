//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest
//element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 3, 4, 1, 5, 7, 2 };
        int best = int.MaxValue;
        int bestCol = 0;
        int a = 0;
        for (int j = 0; j < array.Length; j++)
        {
            for (int i = j; i < array.Length; i++)
            {
                if (best > array[i])
                {
                    best = array[i];
                    bestCol = i;
                }
            }
            while (true)
            {
                int template = array[a];
                array[a] = array[bestCol];
                array[bestCol] = template;
                Console.WriteLine(array[a]);
                a++;
                best = int.MaxValue;
                bestCol = 0;
                break;
            }
        }
    }
}
