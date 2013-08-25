using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length : ");
        int length = int.Parse(Console.ReadLine());
        int[,] matrix = new int[length, length];
        int currentNumber = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = currentNumber;
                currentNumber++;
            }
        }
        //printing on console
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write(matrix[rows, cols]+" ");
            }
            Console.WriteLine();
        }
    }
}
