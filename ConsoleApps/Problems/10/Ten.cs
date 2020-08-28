using ConsoleApps.Common;
using System;

namespace ConsoleApps.Solutions
{
    public class Ten
    {
        public long SumOfPrimes(long num)
        {
            long sum = 0;

            for (long i = 1; i < num; i++)
            {
                if (Tools.IsPrime(i))
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            return sum;
        }
    }
}
