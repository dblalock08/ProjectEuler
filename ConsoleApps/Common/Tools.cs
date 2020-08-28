namespace ConsoleApps.Common
{
    public static class Tools
    {
        public static bool IsPrime(long candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                    return true;

                return false;
            }

            for (int i = 3; i * i <= candidate; i += 2)
            {
                if (candidate % i == 0)
                    return false;
            }

            return candidate != 1;
        }
    }
}
