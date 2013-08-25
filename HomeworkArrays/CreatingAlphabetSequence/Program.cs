//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

    class Program
    {
        static void Main()
        {
           int[] alphabetLetters = new int[26];
           char[] alphaLetters = new char[26];
            for (int i = 0; i < alphabetLetters.Length; i++)
            {
                alphabetLetters[i] = (i + 65);
                char sign = (char)alphabetLetters[i];
                alphaLetters[i] = sign;
            }
            Console.WriteLine("Enter letter : ");
            string letter = Console.ReadLine();
            int bestPos = 0;
            for (int i = 0; i < alphaLetters.Length; i++)
            {
                if (letter == alphaLetters[i].ToString())
                {
                    Console.WriteLine("Number of letter {0} = {1}",alphaLetters[i],(int)alphaLetters[i] - 64);
                }
            }
            

        }
    }
