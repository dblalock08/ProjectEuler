using System;
using ConsoleApps.Solutions;

namespace ConsoleApps
{
    class Program
    {
        private static string _selection = string.Empty;

        static void Main(string[] args)
        {
            while (true)
            {
                switch (_selection)
                {
                    case "3":
                        ProblemThree();
                        break;
                    case "10":
                        ProblemTen();
                        break;
                    case "11":
                        ProblemEleven();
                        break;
                    case "q":
                    case "Q":
                        return;
                }

                ResetSelection();
                _selection = GetSelection();
            }
        }

        #region Helpers

        private static void ResetSelection()
        {
            Console.Clear();
            PrintOptions();
        }

        private static void PrintOptions()
        {
            Console.WriteLine("[3] Largest prime factor");
            Console.WriteLine("[10] Summation of primes");
            Console.WriteLine("[11] Largest product in a grid");

            Console.WriteLine("[q] Quit");
        }

        private static string GetSelection()
        {
            Console.Write("Selection: ");
            var inputLine = Console.ReadLine();

            return inputLine;
        }
        #endregion

        #region Problems
        private static void ProblemThree()
        {
            var three = new PrimeFactors();
            var highestPrime = three.HighestPrimeFactor(600851475143);

            Console.WriteLine($"Highest Prime: {highestPrime}");
            Console.ReadLine();
        }

        private static void ProblemTen()
        {
            long num = 2000000;

            var ten = new Ten();
            long primeSum = ten.SumOfPrimes(num);

            Console.WriteLine($"Sum of all prime numbers less than {num}: {primeSum}");
            Console.ReadLine();
        }

        private static void ProblemEleven()
        {
            var eleven = new Eleven();
            var greatestProduct = eleven.GreatestProduct();

            Console.WriteLine($"Greatest product of four adjacent numbers: {greatestProduct}");
            Console.ReadLine();
        }

        #endregion
    }
}
