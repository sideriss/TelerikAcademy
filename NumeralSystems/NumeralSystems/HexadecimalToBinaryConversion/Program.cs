using System;

class Program
{
    private static string hex2binary(string hexvalue)
    {
        string binaryval = "";
        binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
        return binaryval;
    }
    static void Main()
    {
        Console.WriteLine(hex2binary("C0BD0"));
    }
}

