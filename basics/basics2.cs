using System;

namespace CSharpPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            bool isFirstInputNumber;
            bool isSecondInputNumber;

            Console.WriteLine("Write first number to add:");

            do
            {
                isFirstInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (isFirstInputNumber) {
                    num1 = parsedNum;
                }
            } while (!isFirstInputNumber);

            Console.WriteLine("Write second number to add:");

            do
            {
                isSecondInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (isSecondInputNumber)
                {
                    num2 = parsedNum;
                }
            } while (!isSecondInputNumber);

            int total = num1 + num2;

            Console.WriteLine($"Total is: {total}");

            Console.ReadLine();
        }
    }
}
