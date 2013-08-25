using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length : ");
        int length = int.Parse(Console.ReadLine());
        int[,] integersArray = new int[length, length];
        int row = 0;
        int col = 0;
        string direction = "down";
        int numberOfIntegersToInput = integersArray.GetLength(0) * integersArray.GetLength(0);

        for (int currentNumber = 1; currentNumber <= numberOfIntegersToInput; currentNumber++)
        {
            if (row == integersArray.GetLength(0))
            {
                row--;
                col++;
                direction = "up";
            }

            if (row < 0)
            {
                row++;
                col++;
                direction = "down";
            }

            integersArray[row, col] = currentNumber;

            // Change the row, depending on the direction

            if (direction == "down")
            {
                row++;
            }
            else
            {
                row--;
            }
            //printing on console
        }
        for (int rows = 0; rows < integersArray.GetLength(0); rows++)
        {
            for (int cols = 0; cols < integersArray.GetLength(1); cols++)
            {
                Console.Write(integersArray[rows, cols] + " ");
            }
            Console.WriteLine();
        }
    }
}
