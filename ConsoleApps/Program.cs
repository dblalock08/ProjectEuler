using System;
using ConsoleApps.Solutions;
using ConsoleApps.Solutions._15;

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
                    case "12":
                        ProblemTwelve();
                        break;
                    case "13":
                        ProblemThirteen();
                        break;
                    case "14":
                        ProblemFourteen();
                        break;
                    case "q":
                    case "Q":
                        return;
                }

                PrintOptions();
                _selection = GetSelection();
            }
        }

        private static void PrintOptions()
        {
            Console.WriteLine("[3] Largest prime factor");
            Console.WriteLine("[10] Summation of primes");
            Console.WriteLine("[11] Largest product in a grid");
            Console.WriteLine("[12] Highly divisible triangular number");
            Console.WriteLine("[13] Large sum");
            Console.WriteLine("[14] Longest Collatz sequence");

            Console.WriteLine("[q] Quit");

            //Console.WriteLine("[] ");
        }

        #region Helpers
        private static void ResetSelection()
        {
            Console.Clear();
            PrintOptions();
        }

        private static string GetSelection()
        {
            Console.Write("Selection: ");
            var inputLine = Console.ReadLine();
            Console.WriteLine();

            return inputLine;
        }
        #endregion

        #region Problems
        private static void ProblemThree()
        {
            var three = new PrimeFactors();
            var highestPrime = three.HighestPrimeFactor(600851475143);

            Console.WriteLine($"Highest Prime: {highestPrime}");
            Console.WriteLine();
        }

        private static void ProblemTen()
        {
            long num = 2000000;

            var ten = new Ten();
            long primeSum = ten.SumOfPrimes(num);

            Console.WriteLine($"Sum of all prime numbers less than {num}: {primeSum}");
            Console.WriteLine();
        }

        private static void ProblemEleven()
        {
            var eleven = new Eleven();
            var greatestProduct = eleven.GreatestProduct();

            Console.WriteLine($"Greatest product of four adjacent numbers: {greatestProduct}");
            Console.WriteLine();
        }

        private static void ProblemTwelve()
        {
            var twelve = new Twelve();
            var highestDivisibleTriangularNumber = twelve.DivisibleTriangularNumber();

            Console.WriteLine($"Highest divisible triangular number: {highestDivisibleTriangularNumber}");
            Console.WriteLine();
        }

        private static void ProblemThirteen()
        {
            var thirteen = new Thirteen();
            var firstTenDigits = thirteen.LargeSum();

            Console.WriteLine($"First ten digits of sum: {firstTenDigits}");
            Console.WriteLine();
        }

        private static void ProblemFourteen()
        {
            var fourteen = new Fourteen();
            var longestCollatzSequence = fourteen.CollatzSequence();

            Console.WriteLine($"Longest Collatz sequence: {longestCollatzSequence}");
            Console.WriteLine();
        }

        private static void ProblemFifteen()
        {
            var fifteen = new Fifteen();
            var pathCount = fifteen.LatticePaths();

            Console.WriteLine($"Number of routes through 20x20 grid: {pathCount}");
            Console.WriteLine();
        }

       private static void ProblemSixteen()
        {
            var sixteen = new Sixteen();
            var digitSum = sixteen.PowerDigitSum();

            Console.WriteLine($"Sum of the digits of 2^1000: {digitSum}");
            Console.WriteLine();
        }

        #endregion
    }
}
