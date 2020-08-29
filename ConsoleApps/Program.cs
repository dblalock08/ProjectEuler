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
                    case "12":
                        ProblemTwelve();
                        break;
                    case "13":
                        ProblemThirteen();
                        break;
                    case "14":
                        ProblemFourteen();
                        break;
                    case "15":
                        //ProblemFifteen();
                        break;
                    case "16":
                        ProblemSixteen();
                        break;
                    case "17":
                        ProblemSeventeen();
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
            //Console.WriteLine("[15] Lattice paths");
            Console.WriteLine("[16] Power digit sum");
            Console.WriteLine("[17] Number letter counts");


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

        private static void ProblemSeventeen()
        {
            var seventeen = new Seventeen();
            var count = seventeen.NumberLetterCount();

            Console.WriteLine($"Number of letters in the numbers 1 to 1000 when written out: {count}");
            Console.WriteLine();
        }

        #endregion
    }
}
