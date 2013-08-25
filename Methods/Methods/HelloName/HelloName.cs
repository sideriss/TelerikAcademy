using System;

class HelloName
{
    static void Main()
    {
       Print();
    }
    static void Print()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello {0}!!!",name);
    }

}

