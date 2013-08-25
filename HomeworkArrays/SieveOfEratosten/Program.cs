// Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        uint range = 10000000;
        bool[] prime = new bool[range + 1];
        //by default they're all false

        for (uint i = 2; i <= range; i++)
        {
            prime[i] = true;
            //set all numbers to true
        }

        //exclude the non primes by finding multipliers
        for (uint j = 2; j <= range; j++)
        {
            if (prime[j])
            //is true
            {
                for (uint p = 2; (p * j) <= range; p++)
                {
                    prime[p * j] = false;
                }
            }
        }

        int countPrimes = 0;
        for (int i = 0; i <= range; i++)
        {
            if (prime[i])
            {
                countPrimes++;
            }
        }

        //print result from 2 to 10 000 000, because by default one is not a prime
        Console.WriteLine("The count of primes from 2 to 10 000 000 is {0}.", countPrimes);
    }
}