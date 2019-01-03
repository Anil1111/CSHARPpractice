using System;

namespace CSharpPractice1
{
    class Program
    {
        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static int GetSumOfPrimeNumbers(int limit)
        {
            int sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSumOfPrimeNumbers(500));

            Console.ReadLine();
        }
    }
}
