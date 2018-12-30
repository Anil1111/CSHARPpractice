using System;

namespace CSharpPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            bool isFirstInputNumber;
            bool isSecondInputNumber;
            bool isThirdInputNumber;

            Console.WriteLine("Input the first number to multiply:");

            do
            {
                isFirstInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (isFirstInputNumber) {
                    num1 = parsedNum;
                }
            } while (!isFirstInputNumber);

            Console.WriteLine("Input the socond number to multiply:");

            do
            {
                isSecondInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (isSecondInputNumber)
                {
                    num2 = parsedNum;
                }
            } while (!isSecondInputNumber);

            Console.WriteLine("Input the third number to multiply:");

            do
            {
                isThirdInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (isThirdInputNumber)
                {
                    num3 = parsedNum;
                }
            } while (!isThirdInputNumber);

            int total = num1 * num2 * num3;

            Console.WriteLine($"Total: {total}");

            Console.ReadLine();
        }
    }
}
