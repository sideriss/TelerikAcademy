using System;

class Program
{
    static bool BiggerThanNeighbors(int[] array, int position)
    {
        if (array[position] > array[position + 1] && array[position] > array[position - 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.Write("Enter array length : ");
        int lenth = int.Parse(Console.ReadLine());
        int[] array = new int[lenth];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter [{0}] element : ", i);
            int element = int.Parse(Console.ReadLine());
            array[i] = element;
        }
        int position = int.Parse(Console.ReadLine());
        while (position+1 > array.Length-1 || position-1 < 0)
        {
            Console.Write("Enter new positions in array between 0 and {0} : ", array.Length - 2);
            position = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(BiggerThanNeighbors(array, position));
    }
}

