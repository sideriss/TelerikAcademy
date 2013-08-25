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
        for (int i = 0; i < array.Length-1; i++)
        {
            if (BiggerThanNeighbors(array, i) == true)
            {
               Console.WriteLine(BiggerThanNeighbors(array, i));
               Console.WriteLine("Index is "+i);
               break;
            }
        }
    }
}
