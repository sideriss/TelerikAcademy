using System;

class Program
{
    public static int MostFreq(int[] _M, out int x)
    {
        //First I need to sort the array in ascending order
        int Max_Freq, No_Freq, i, k;
        Array.Sort(_M);
        k = _M[0];
        Max_Freq = 0; i = 0; x = 0;
        while (i < _M.Length)
        {
            //No_Freq= the frequency of the current number
            No_Freq = 0;
            //X here is the number which is appear in the array Frequently 
            while (k == _M[i])
            {
                No_Freq++;
                i++;
                if (i == _M.Length)
                    break;
            }
            if (No_Freq > Max_Freq)
            {
                //so it will be printed the same
                Max_Freq = No_Freq;
                x = k;
            }
            if (i < _M.Length) k = _M[i];
        }
        return (Max_Freq);
    }
    static void Main()
    {
        Console.Write("Enter how much elements will have your array : ");
        int[] M = new int [int.Parse(Console.ReadLine())];
        for (int i = 0; i < M.Length; i++)
        {
            Console.Write("Element [{0}] = ",i);
            M[i] = int.Parse(Console.ReadLine());
        }
        int x;
        int f = MostFreq(M, out x);
        Console.WriteLine("The most Frequent Item = {0} with frequency = {1}", x, f);
    }
}