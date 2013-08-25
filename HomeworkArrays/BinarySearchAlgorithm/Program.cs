using System;

class FindIndexBinarySearch
{
    static void Main()
    {
        //reading the input data from the console
        uint sizeOfArray;
        do
        {
            Console.Write("Please enter the size of array: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out sizeOfArray));

        Console.Write("Enter the index of which number you are searching: ");
        int Pivot = int.Parse(Console.ReadLine());
        bool numberExists = false;

        int[] arrayOfIntegers = new int[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            do
            {
                Console.Write("Please enter element {0} of array: ", i);
            }
            while (!int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]));
        }

        // sort array
        Array.Sort(arrayOfIntegers);

        //print sorted array
        Console.Write("The sorted array is:");
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.Write("{0} ", arrayOfIntegers[i]);
        }
        Console.WriteLine();

        //binary search algorithm
        int Start= 0;
        int End = arrayOfIntegers.Length;
        int Center = (Start + End)/2;
        int counter = 0;

        while (arrayOfIntegers[Center] != Pivot)
        {
            while (arrayOfIntegers[Center] > Pivot)
            {
                End = Center;
                Center = (Start + End) / 2;
                if (arrayOfIntegers[Center] == Pivot)
                {
                    numberExists = true;
                }
                counter++;
                if (counter == 10)
                {
                    break;
                }
            }
            while (arrayOfIntegers[Center] < Pivot)
            {
                Start = Center;
                Center = (Start + End) / 2;
                if (arrayOfIntegers[Center] == Pivot)
                {
                    numberExists = true;
                    break;
                }
                counter++;
                if (counter == 10)
                {
                    break;
                }
            }
            if (counter == 10)
            {
                break;
            }
        }
        if (arrayOfIntegers[Center] == Pivot)
        {
            numberExists = true;
        }
        Console.WriteLine(numberExists);
        
    }
}