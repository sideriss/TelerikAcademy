using System;

class Program
{
    static void Main()
    {
        string HexVal = "C0BD0";
        int DecimalVal = Convert.ToInt32(HexVal, 16);
        Console.WriteLine(DecimalVal);
    }
}

