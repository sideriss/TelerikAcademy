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

        /* We will use the nextRow and nextCol variable to check what is the next cell we are going to visit. They will depend on the direction,
* so we will start with nextRow = 1 and nextCol = 0, since were are moving down ar first */
        int nextRow = 1;
        int nextCol = 0;

        for (int currentNumber = 1; currentNumber <= numberOfIntegersToInput; currentNumber++)
        {
            // Fill in the cell
            integersArray[row, col] = currentNumber;

            // Check if we need to change direction (that will be when the next cell is out boundaries OR is filled)
            bool switchDirection = false;

            if (((row + nextRow) == integersArray.GetLength(0)) || ((col + nextCol) == integersArray.GetLength(1)) ||
                ((row + nextRow) < 0) || ((col + nextCol) < 0))
            {
                switchDirection = true;
            }
            else if (((row + nextRow) < integersArray.GetLength(0)) || ((col + nextCol) < integersArray.GetLength(1)) ||
                    ((row + nextRow) >= 0) || ((col + nextCol) >= 0))
            {
                if (integersArray[(row + nextRow), (col + nextCol)] != 0)
                {
                    switchDirection = true;
                }
            }

            if (switchDirection)
            {
                switch (direction)
                {
                    case "down": direction = "right"; break;
                    case "right": direction = "up"; break;
                    case "up": direction = "left"; break;
                    case "left": direction = "down"; break;
                    default: break;
                }
            }

            // Apply direction
            if (direction == "down")
            {
                nextRow = 1;
                nextCol = 0;
            }
            else if (direction == "up")
            {
                nextRow = -1;
                nextCol = 0;
            }
            else if (direction == "right")
            {
                nextRow = 0;
                nextCol = 1;
            }
            else
            {
                nextRow = 0;
                nextCol = -1;
            }

            row += nextRow;
            col += nextCol;
        }
        for (int rows = 0; rows < integersArray.GetLength(0); rows++)
        {
            for (int cols = 0; cols < integersArray.GetLength(1); cols++)
            {
                Console.Write(integersArray[rows, cols] + "   ");
            }
            Console.WriteLine();
        }
    }
}
