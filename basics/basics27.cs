using System;
using System.Collections.Generic;

namespace CSharpPractice1
{
    class Program
    {
        public static int[] digitArr(int n)
        {
            if (n == 0) return new int[1] {0};

            List<int> digits = new List<int>();

            for (; n != 0; n /= 10)
            {
                digits.Add(n % 10);
            }

            int[] arr = digits.ToArray();
            Array.Reverse(arr);
            return arr;
        }

        public static int ComputeSumOfInt(int num)
        {
            int sum = 0;
            int[] numArray = digitArr(num);

            for (int i = 0; i < numArray.Length; i++)
            {
                sum += numArray[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ComputeSumOfInt(12));

            Console.ReadLine();
        }
    }
}
