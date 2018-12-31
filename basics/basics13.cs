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

            for (int i = 0; i < inputNumber; i++)
            {
                if (i == 0 || i == inputNumber - 1)
                {
                    Console.WriteLine(String.Format("{0}{0}{0}", inputNumber));
                }
                else
                {
                    string spaces = "".PadRight(inputNumber.ToString().Length, ' ');
                    Console.WriteLine(String.Format("{0}{1}{0}", inputNumber, spaces));
                }
            }

            Console.ReadLine();
        }
    }
}
