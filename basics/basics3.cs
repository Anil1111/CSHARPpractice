using System;

namespace CSharpPractice1
{
    class Program
    {
        public static void DivideTwoNumbers()
        {
            int total = 0;
            int num1 = 0;
            int num2 = 0;
            bool isFirstInputNumber;
            bool isSecondInputNumber;

            Console.WriteLine("Write first number to add:");

            do
            {
                isFirstInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                if (isFirstInputNumber)
                {
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

            try
            {
                total = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                DivideTwoNumbers();
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine($"Total is: {total}");

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            DivideTwoNumbers();
        }
    }
}
