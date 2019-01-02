using System;

namespace CSharpPractice1
{
    class Program
    {
        public static bool checkNum(int num)
        {
            if (Math.Abs(num - 100) <= 10 || Math.Abs(num - 200) <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(checkNum(2));

            Console.ReadLine();
        }
    }
}
