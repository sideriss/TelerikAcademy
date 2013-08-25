using System;
 
class HowManyTimesNumAppearInArr
{
    static int FindHowManyTimesNumAppear(int[] arr, int arrLength, int num)
    {
        int counter = 0;
        for (int i = 0; i < arrLength; i++)
        {
            if (arr[i] == num)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.Write("Enter array length : ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter [{0}] element : ", i);
            int num = int.Parse(Console.ReadLine());
            arr[i] = num;
        }
        int arrLength = arr.Length;
        Console.Write("Enter in witch number you are interested in : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Numer {0} exist {1} times in this array !",n,FindHowManyTimesNumAppear(arr, arrLength, n));
    }
}