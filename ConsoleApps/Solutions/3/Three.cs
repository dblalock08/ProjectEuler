using ConsoleApps.Common;
using System;

namespace ConsoleApps.Solutions
{
    public class PrimeFactors
    {
        public long HighestPrimeFactor(long num)
        {
            //List<long> primes = new List<long>();
            long highestPrime = 0;

            for (long i = 1; i < Math.Sqrt(num); i++)
            {
                if (i % 100000000 == 0)
                    PrintRemaining(num, i);

                if (num % i == 0 && Tools.IsPrime(i))
                {
                    //Console.WriteLine(i);
                    highestPrime = i;
                }
            }

            return highestPrime;
        }

        private void PrintRemaining(long num, long iteration)
        {
            Console.WriteLine($"{(num / 2) - iteration} remaining");
        }
    }
}
