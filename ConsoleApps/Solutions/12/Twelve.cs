using System;

namespace ConsoleApps.Solutions
{
    public class Twelve
    {
        public int DivisibleTriangularNumber()
        {
            int highestNumber = 0;
            int i = 1;

            while (NumberOfDivisors(highestNumber) < 500)
            {
                highestNumber += i;
                i++;
            }

            return highestNumber;
        }

        private int NumberOfDivisors(int num)
        {
            int numOfDivisors = 0;
            int sqrt = (int)Math.Sqrt(num);

            for (int i = 1; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    numOfDivisors += 2;
                }
            }

            // Perfect squares
            if (sqrt * sqrt == num)
            {
                numOfDivisors--;
            }

            return numOfDivisors;
        }
    }
}
