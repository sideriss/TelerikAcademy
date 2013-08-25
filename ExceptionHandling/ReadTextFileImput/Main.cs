using System;

class program
{
    static void Main()
    {
        try
        {
            ConsoleHelper.SetConsoleFont(0); //Set the font size to  the smallest possible
            Console.SetBufferSize(300, 116); // Set window size
            Console.SetWindowSize(300, 116);
            string[] graphic = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\" + "ConsoleReading.txt");
            foreach (var element in graphic) // print .txt file
            {
                Console.WriteLine(element);
            }
        }
        catch
        {
            Console.WriteLine("Something is wrong");
        }
    }
}
