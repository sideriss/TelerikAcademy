using System;

namespace BinaryToDecimalConversion
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter binary number : ");
            string s = Console.ReadLine();    // my binary "number" as a string
            int dec = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // we start with the least significant digit, and work our way to the left
                if (s[s.Length - i - 1] == '0')
                {
                    continue;
                }
                dec += (int)Math.Pow(2, i);
            }
            Console.WriteLine("Decimal representation is : "+dec);
        }
    }
}
