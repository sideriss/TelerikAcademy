using System;

class Program
{
    static int MaximalElement(int[] array, int max , int min, int maxElement)
    {
        for (int i = min; i < max; i++)
        {
            if (array[i] > array [i+1])
            {
                maxElement = array[i];
            }
        }
        return maxElement;
    }
    static void Main()
    {
        Console.Write("Enter array length : ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter [{0}] element : ", i);
            int element = int.Parse(Console.ReadLine());
            array[i] = element;
        }
        Console.Write("Enter lowerPortion starts : ");
        int lowerPortion = int.Parse(Console.ReadLine());
        Console.Write("Enter upperPortion starts : ");
        int upperPortion = int.Parse(Console.ReadLine());
        Console.WriteLine("Maximal Element is : "+MaximalElement(array,upperPortion,lowerPortion,0));
    }
}

