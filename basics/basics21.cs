using System;

namespace CSharpPractice1
{
    class Program
    {
        public static bool checkSum(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;

            if (numOne == 20 || numTwo == 20 || sum == 20)
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
            Console.WriteLine(checkSum(2, 5));

            Console.ReadLine();
        }
    }
}
