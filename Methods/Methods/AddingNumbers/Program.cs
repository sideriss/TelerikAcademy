using System;
using System.Linq;
using System.Numerics;

namespace PositiveIntegers
{
    class PositiveIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first numner: ");
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Enter second numner: ");
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());

            int[] arr1 = BigIntToArray(num1);
            int[] arr2 = BigIntToArray(num2);
            int[] arr3 = SumTwoDigitArrays(arr1, arr2);

            for (int i = arr3.Length - 1; i >= 1; i--)
            {
                Console.Write(arr3[i]);
            }
            Console.WriteLine(arr3[0]);
        }

        static int[] BigIntToArray(BigInteger n)
        {
            int[] digits = new int[NumberOfDigits(n)];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = (int)(n % 10);
                n = n / 10;
            }
            return digits;
        }

        //returns the number of digits of a number
        static int NumberOfDigits(BigInteger n)
        {
            int digits = 1;
            for (BigInteger i = 10; n / i != 0; i *= 10)
            {
                digits++;
            }
            return digits;
        }

        //sums two arrays of digits
        static int[] SumTwoDigitArrays(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[Math.Max(arr1.Length, arr2.Length) + 1];
            int carry = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                arr3[i] = (arr1[i] + arr2[i] + carry) % 10;
                if (arr1[i] + arr2[i] + carry >= 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            if (arr1.Length >= arr2.Length)
            {
                for (int i = arr2.Length; i < arr1.Length; i++)
                {
                    arr3[i] = arr1[i] + carry;
                    if (arr1[i] + carry >= 10)
                    {
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                }
            }
            else
            {
                for (int i = arr1.Length; i < arr2.Length; i++)
                {
                    arr3[i] = arr2[i] + carry;
                    if (arr2[i] + carry >= 10)
                    {
                        carry = 1;
                    }
                    else
                    {
                        carry = 0;
                    }
                }
            }
            if (carry == 0)
            {
                Array.Resize(ref arr3, arr3.Length - 1);
            }
            else
            {
                arr3[arr3.Length - 1] += carry;
            }

            return arr3;
        }
    }
}