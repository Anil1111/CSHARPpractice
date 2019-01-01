using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice1
{
    class Program
    {
        public static string SwapFirstAndLastChar(string str)
        {

            StringBuilder newString = new StringBuilder();
            List<char> strCharArray = new List<char>(str.ToCharArray());

            char tempFirstChar = strCharArray[0];
            strCharArray[0] = strCharArray[strCharArray.Count - 1];
            strCharArray[strCharArray.Count - 1] = tempFirstChar;

            for (int i = 0; i < strCharArray.Count; i++)
            {
                newString.Append(strCharArray[i]);
            }

            return newString.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Test Data:");

            string inputString = Console.ReadLine();

            Console.WriteLine(SwapFirstAndLastChar(inputString));

            Console.ReadLine();
        }
    }
}
