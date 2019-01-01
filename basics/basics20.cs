using System;

namespace CSharpPractice1
{
    class Program
    {
        public static int computeDifference(int numOne, int numTwo)
        {
            int absValueOfSum = Math.Abs(numOne - numTwo);

            if (numOne > numTwo)
            {
                return 2 * absValueOfSum;
            }
            else
            {
                return absValueOfSum;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(computeDifference(2, 5));

            Console.ReadLine();
        }
    }
}
