using System;
using System.Linq;
using System.Text;

namespace CSharpPractice1
{
    class Program
    {
        public static string ReverseWords(string sentence)
        {
            string[] sentenceArr = sentence.Split(' ');
            sentenceArr.Reverse();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < sentenceArr.Length; i++)
            {
                sb.Append(sentenceArr[i] + " ");
            }

            return sb.ToString().Trim();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("Display the pattern like pyramid using the alphabet."));

            Console.ReadLine();
        }
    }
}
