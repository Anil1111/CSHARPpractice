using System;

namespace CSharpPractice1
{
    class Program
    {


        static void Main(string[] args)
        {
            int inputNumber = 0;
            bool isValidInput;

            Console.WriteLine("Enter a random number:");

            do
            {
                isValidInput = int.TryParse(Console.ReadLine(), out int parseNumber);
                if (isValidInput)
                {
                    inputNumber = parseNumber;
                }
                else
                {
                    Console.WriteLine("Invalid number. Try again!");
                }
            } while (!isValidInput);

            Console.WriteLine(String.Format("{0} {0} {0} {0}", inputNumber));
            Console.WriteLine(String.Format("{0}{0}{0}{0}", inputNumber));

            Console.ReadLine();
        }
    }
}
