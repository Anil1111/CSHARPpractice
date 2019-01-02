using System;

namespace CSharpPractice1
{
    class Program
    {
        public static void PrintOddNumbers(int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            PrintOddNumbers(1, 99);

            Console.ReadLine();
        }
    }
}
