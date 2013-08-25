//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class comparingCharArray
{
    static void Main()
    {
        // string is a char array and you can read it from console
        Console.Write("Enter first char array : ");
        string first = Console.ReadLine();
        Console.Write("Enter second char array : ");
        string second = Console.ReadLine();
        // initializing boolean variable
        bool areEqual = true;
        // if the length of first is not equal to length of second they can't be equal
        if (first.Length > second.Length)
        {
            areEqual = false;
        }
        if (second.Length > first.Length)
        {
            areEqual = false;
        }
        // comparing the characters by indexer
        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
            {
                areEqual = false;
            }
        }
        Console.WriteLine("Are they equal ---->  "+ areEqual);
    }
}
