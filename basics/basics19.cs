using System;

namespace CSharpPractice1
{
    class Program
    {
        public static int computeSum(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;

            if (numOne == numTwo)
            {
                return 3 * sum;
            }
            else
            {
                return sum;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(computeSum(5, 5));

            Console.ReadLine();
        }
    }
}
