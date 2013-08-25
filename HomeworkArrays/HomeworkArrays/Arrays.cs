//Write a program that allocates array of 20 integers and initializes 
//each element by its index multiplied by 5. Print the obtained array on the console.

using System;

class Arrays
{
    static void Main()
    {
        // initializing the Array
        int[] array = new int[20];
        //setting the value of index multiplied by 5 and print
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            int currentElement = array[i];
            Console.WriteLine("[{0}] element = {1}",i,currentElement);
        }
    }
}
