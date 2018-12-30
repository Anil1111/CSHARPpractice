using System;

namespace CSharpPractice1
{
    class Program
    {
        public static void CalcThreeNumbers()
        {
            int n = 3;
            bool isInputNumber;
            int[] inputs = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the number {i + 1}:");

                do
                {
                    isInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                    if (isInputNumber)
                    {
                        inputs[i] = parsedNum;
                    }
                } while (!isInputNumber);
            }

            int x = inputs[0];
            int y = inputs[1];
            int z = inputs[2];

            int firstCalc = (x + y) * z;
            int secondCalc = x * y + y * z;

            Console.WriteLine($"Result of specified numbers {inputs[0]}, {inputs[1]} and {inputs[2]}, (x+y)*z is {firstCalc} and x*y + y*z is {secondCalc}");

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            CalcThreeNumbers();
        }
    }
}
