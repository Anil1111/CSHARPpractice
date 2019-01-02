using System;

namespace CSharpPractice1
{
    class Program
    {
        public static string FindLongestWord(string str)
        {
            string longestString = "";
            string[] strChars = str.Split();

            for (int i = 0; i < strChars.Length; i++)
            {
                if (strChars[i].Length > longestString.Length)
                {
                    longestString = strChars[i];
                }
            }

            return longestString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");

            string inputString = Console.ReadLine();

            Console.WriteLine(FindLongestWord(inputString));

            Console.ReadLine();
        }
    }
}
