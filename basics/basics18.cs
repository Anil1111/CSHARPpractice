using System;

namespace CSharpPractice1
{
    class Program
    {
        public static bool isOnePositiveOtherNegative(int numOne, int numTwo)
        {

            if ((numOne < 0 && numTwo > 0) || (numOne > 0 && numTwo < 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isOnePositiveOtherNegative(5, -2));

            Console.ReadLine();
        }
    }
}
