using System;

namespace CSharpPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Write your name:");

            name = Console.ReadLine();
            Console.WriteLine($"Hello: {name}");

            Console.ReadLine();
        }
    }
}
