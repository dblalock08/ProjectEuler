using System.Collections.Generic;

namespace ConsoleApps.Solutions
{
    public class Fourteen
    {
        private const int _startValue = 1000000;
        public long CollatzSequence()
        {
            //return OptimizedMethod();
            return DirectMethod();
        }

        private long OptimizedMethod()
        {
            return -1;
        }

        private long DirectMethod()
        {
            long highestStart = 0;

            long highestSequence = 0, currentSequenceLength = 0;
            for (int i = _startValue; i > 0; i--)
            {
                currentSequenceLength = 1;

                long num = i;
                while (num != 1)
                {
                    currentSequenceLength++;

                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = num * 3 + 1;
                    }
                }

                if (currentSequenceLength > highestSequence)
                {
                    highestSequence = currentSequenceLength;
                    highestStart = i;
                };
            }

            return highestStart;
        }

        private int Odd(int num)
        {
            return num * 3 + 1;
        }

        private int Even(int num)
        {
            return num / 2;
        }

    }
}
