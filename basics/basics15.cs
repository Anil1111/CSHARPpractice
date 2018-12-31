using System;

namespace CSharpPractice1
{
    class Program
    {
        public static string RemoveCharAt(string str, int index)
        {
            // str.Remove(index, 1);

            StringBuilder newString = new StringBuilder();
            List<char> strCharArray = new List<char>(str.ToCharArray());

            strCharArray.RemoveAt(index);


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

            Console.WriteLine(RemoveCharAt(inputString, 2));

            Console.ReadLine();
        }
    }
}
