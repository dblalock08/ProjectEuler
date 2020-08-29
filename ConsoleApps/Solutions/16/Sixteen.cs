using System;
using System.Linq;
using System.Numerics;

namespace ConsoleApps.Solutions
{
    public class Sixteen
    {
        public long PowerDigitSum()
        {
            return DirectMethod();
        }

        private long DirectMethod()
        {
            long digitSum = 0;

            // Use .NET BigInteger
            BigInteger powerValue = new BigInteger(Math.Pow(2, 1000));

            // Convert to char array and add the values
            int[] digits = powerValue.ToString().ToCharArray().Select(c => (int) char.GetNumericValue(c)).ToArray();

            foreach (var item in digits)
            {
                digitSum += item;
            }

            return digitSum;
        }
    }
}
