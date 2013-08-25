using System;

class RandomNumbers
{
    static void Main()
    {
        Random randomNumber = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomNumber.Next());
        }
    }
}

