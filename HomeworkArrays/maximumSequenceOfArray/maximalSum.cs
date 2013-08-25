//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class maximalSum          // super bataka v krainite slu4ai ne iska muchih q da q pravq
    // da pokazva indeksite s 9 ki mi bugva primerno 4 devqtki posledni i mi dava sum 36 correct i pe4ata 5 devqtki!!!
{
    static void Main()
    {
        int[] array = { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
        int bigSum = int.MinValue;
        int element = 0;
        int counter = 0;
        int bestCounter = int.MinValue;
        int best = 0;
        int minsum = int.MinValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i+1])
            {
                while (element < array[i])
                {
                    element = array[i];
                    counter++;
                }
                counter++;
                element += array[i];
                if (element > bigSum)
                {
                    bigSum = element;
                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                }
                if (bigSum > minsum)
                {
                    minsum = bigSum;
                    best = i + 1;
                }
            }
            else
            {
                element = 0;
                counter = 0;
            }
        }
        for (int i = bestCounter; i < bestCounter; i++)
        {
            Console.WriteLine(bestCounter - i - 1);
        }
        Console.WriteLine();
        Console.Write("The elements are : ");
        for (int i = 0; i < bestCounter; i++)
        {
            Console.Write(array[best] + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("With sum of : "+bigSum);
        Console.ReadLine();
    }
}

