using System;
using ConsoleApps.Solutions;

namespace ConsoleApps
{
    class Program
    {
        private static int _selection = 0;

        static void Main(string[] args)
        {
            while (_selection <= 1)
            {
                ResetSelection();
                _selection = GetSelection();
            }

            switch (_selection)
            {
                case 3:
                    ProblemThree();
                    break;
                case 10:
                    ProblemTen();
                    break;
                case 11:
                    ProblemEleven();
                    break;
                default:
                    ResetSelection();
                    break;
            }

            // Wait for input
            Console.ReadLine();
        }

        #region Helpers

        private static void ResetSelection()
        {
            Console.Clear();
            PrintOptions();
        }

        private static void PrintOptions()
        {
            Console.WriteLine("[3] Highest Prime Factor of 60,085,1475,143");
            Console.WriteLine("[10] Sum of all primes below 2,000,000");
        }

        private static int GetSelection()
        {
            Console.Write("Number: ");
            var inputLine = Console.ReadLine();

            if (int.TryParse(inputLine, out var selection))
                return selection;

            return 0;
        }
        #endregion

        #region Problems
        private static void ProblemThree()
        {
            var three = new PrimeFactors();
            var highestPrime = three.HighestPrimeFactor(600851475143);

            Console.WriteLine($"Highest Prime: {highestPrime}");
        }

        private static void ProblemTen()
        {
            long num = 2000000;

            var ten = new Ten();
            long primeSum = ten.SumOfPrimes(num);

            Console.WriteLine($"Sum of all prime numbers less than {num}: {primeSum}");
        }

        private static void ProblemEleven()
        {
            var eleven = new Eleven();
            var greatestProduct = eleven.GreatestProduct();

            Console.WriteLine($"Greatest product of four adjacent numbers: {greatestProduct}");
        }

        #endregion
    }
}
