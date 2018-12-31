using System;

namespace CSharpPractice1
{
    class Program
    {


        static void Main(string[] args)
        {
            int inputTemp = 0;
            bool isValidTemp;

            Console.WriteLine("Enter the amount of celsius:");

            do
            {
                isValidTemp = int.TryParse(Console.ReadLine(), out int parseTemp);
                if (isValidTemp)
                {
                    inputTemp = parseTemp;
                }
                else
                {
                    Console.WriteLine("Invalid temperature. Try again!");
                }
            } while (!isValidTemp);

            int tempInKelvin = inputTemp + 273;
            int tempInFahrenheit = (inputTemp * 9 / 5) + 32;

            Console.WriteLine($"Kelvin = {tempInKelvin}");
            Console.WriteLine($"Fahrenheit = {tempInFahrenheit}");

            Console.ReadLine();
        }
    }
}
