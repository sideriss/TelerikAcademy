using System;

class Program
{
    static void Main()
    {                 //0  1  2  3  4  5  6  7  8  9
        int[] array = { 1, 2, 3, 4, 4, 4, 4, 4, 4, 4};
        int start = 0;
        int len = 1;
        int bestLen = 1;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                len++;
                if (len > bestLen)
                {
                    start = i + 1;
                    bestLen = len;
                }
            }
            else
            {
                len = 1;
            }
        }
        int sum = 0;
        for (int i = start - bestLen + 1; i <= start; i++)  
        {
            Console.Write("Elements [{0}] = ", i);
            Console.WriteLine(array[i] + " ");
            sum += array[i];
        }
        Console.WriteLine();
        Console.WriteLine("With sum of : "+sum);
    }
}
