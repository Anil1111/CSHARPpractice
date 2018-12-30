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

            Console.WriteLine("Write first number to swap:");

            do
            {
                isFirstInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (isFirstInputNumber) {
                    num1 = parsedNum;
                }
            } while (!isFirstInputNumber);

            Console.WriteLine("Write second number to swap:");

            do
            {
                isSecondInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (isSecondInputNumber)
                {
                    num2 = parsedNum;
                }
            } while (!isSecondInputNumber);

            int beforeSwapNum1 = num1;
            int beforeSwapNum2 = num2;

            num2 = num1 + num2; // num1 = 5, num2 = 15
            num1 = num2 - num1; // num1 = 10, num2 = 15
            num2 = num2 - num1; // num1 = 10, num2 = 5

            Console.WriteLine($"Before swap numbers were {beforeSwapNum1} {beforeSwapNum2}");
            Console.WriteLine($"After swap numbers were {num1} {num2}");

            Console.ReadLine();
        }
    }
}
