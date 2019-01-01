using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice1
{
    class Program
    {
        public static string AddFirstCharToFrontAndBack(string str)
        {

            StringBuilder newString = new StringBuilder();
            List<char> strCharArray = new List<char>(str.ToCharArray());

            char firstChar = strCharArray[0];

            strCharArray.Insert(0, firstChar);
            strCharArray.Add(firstChar);

            for (int i = 0; i < strCharArray.Count; i++)
            {
                newString.Append(strCharArray[i]);
            }

            return newString.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input a string:");

            string inputString = Console.ReadLine();

            Console.WriteLine(AddFirstCharToFrontAndBack(inputString));

            Console.ReadLine();
        }
    }
}
