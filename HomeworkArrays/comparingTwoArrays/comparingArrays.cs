//Write a program that reads two arrays from the console and compares them element by element.

using System;

class comparingArrays
{
    static void Main()
    {
        // initializing two arrays 
        int[] firstArray = { 2, 3, 4, 5, 6 };
        int[] secondArray = { 2, 3, 4, 5, 6 };
        //initializing the boolean value
        bool areTheySame = true;
        // if the massive's length are not the same they can't be equal
        if (firstArray.Length > secondArray.Length)
        {
            areTheySame = false;
        }
        else if (firstArray.Length < secondArray.Length)
        {
            areTheySame = false;
        }
        // comparing each element with for cycle
                for (int i = 0; i < (firstArray.Length + secondArray.Length) / 2; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        areTheySame = false;
                    }
                }
        Console.WriteLine(areTheySame);
    }
}

