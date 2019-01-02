using System;

namespace CSharpPractice1
{
    class Program
    {
        public static string StringToLower(string str)
        {
            return str.ToLower();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string and it will be converted into lower case:");

            string inputString = Console.ReadLine();

            Console.WriteLine(StringToLower(inputString));

            Console.ReadLine();
        }
    }
}
