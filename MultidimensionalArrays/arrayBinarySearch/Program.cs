using System;

class ArrayBinarySearch
{
    static void Main()
    {

        // Get the length of the array and the number K
        Console.Write("Please enter number K: ");
        int numberK = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nPlease enter how many integers you want to put in tha array: ");
        int numberOfIntegers = Convert.ToInt32(Console.ReadLine());

        int[] integersArray = new int[numberOfIntegers];

        // Get the integers from the console and place them in the array
        Console.WriteLine("\nPlease enter the number you want to place in the array: ");
        for (int index = 0; index < integersArray.Length; index++)
        {
            int currentInteger = Convert.ToInt32(Console.ReadLine());
            integersArray[index] = currentInteger;
        }

        // Sort the array
        Array.Sort(integersArray);

        // Find the largest number in the array that is less or equal to K
        bool answerFound = false;
        int answer = 0;

        for (int i = numberK; i >= integersArray[0]; i--)
        {
            if (Array.BinarySearch(integersArray, i) >= 0)
            {
                answer = integersArray[Array.BinarySearch(integersArray, i)];
                answerFound = true;
                break;
            }
        }

        // Printing
        if (answerFound)
        {
            Console.WriteLine("\nThe largest number in the array that is <= K is {0}\n", answer);
        }
        else
        {
            Console.WriteLine("\nThere is no number in the array that is <= K\n");
        }

    }
}