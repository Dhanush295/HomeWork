using System;
namespace Assignment1
{
    public class PrimeNumber
    {
        public static int[] DisplayPrimeNumber(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray();
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        
    }
}
