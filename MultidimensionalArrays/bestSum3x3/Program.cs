using System;

class Program
{
    static void Main()
    {
        // Initializing the matrix
        int[,] matrix = 
        {
            {3,1,0,2,0,3,2,1,4,9},
            {2,3,4,2,1,2,3,9,9,9},
            {2,4,4,3,4,1,9,9,9,9},
            {2,3,4,1,2,3,1,9,9,9}
        };
        // Declaring variables for bestSum

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
            {
                int sum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2] + matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols+2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = rows;
                    bestCol = cols;
                }
            }
        }
        Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine();
        Console.WriteLine("The sum is : {0}", bestSum);
    }
}
