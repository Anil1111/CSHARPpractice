using System;

namespace CSharpPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool isInputNumber;

            Console.WriteLine("Enter the number:");

            do
            {
                isInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (isInputNumber) {
                    num = parsedNum;
                }
            } while (!isInputNumber);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

            Console.ReadLine();
        }
    }
}
