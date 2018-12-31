using System;

namespace CSharpPractice1
{
    class Program
    {


        static void Main(string[] args)
        {
            int age = 0;
            bool isValidAge;

            Console.WriteLine("Enter your age:");

            do
            {
                isValidAge = int.TryParse(Console.ReadLine(), out int parsedAge);
                if (isValidAge)
                {
                    age = parsedAge;
                }
                else
                {
                    Console.WriteLine("Invalid age. Try again!");
                }
            } while (!isValidAge);

            Console.WriteLine($"You look older than {age}");

            Console.ReadLine();
        }
    }
}
