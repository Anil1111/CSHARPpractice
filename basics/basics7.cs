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


            int add = num1 + num2;
            int sub = num1 - num2;
            int mul = num1 * num2;
            int div = num1 / num2;
            int mod = num1 % num2;

            Console.WriteLine($"{num1} + {num2} = {add}");
            Console.WriteLine($"{num1} - {num2} = {sub}");
            Console.WriteLine($"{num1} * {num2} = {mul}");
            Console.WriteLine($"{num1} / {num2} = {div}");
            Console.WriteLine($"{num1} % {num2} = {mod}");

            Console.ReadLine();
        }
    }
}
