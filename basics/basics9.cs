using System;

namespace CSharpPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            bool isInputNumber;
            int sumOfNumbers = 0;
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the number {i + 1}:");

                do
                {
                    isInputNumber = int.TryParse(Console.ReadLine(), out int parsedNum);
                    if (isInputNumber)
                    {
                        nums[i] = parsedNum;
                        sumOfNumbers += parsedNum;
                    }
                } while (!isInputNumber);
            }           

            int average = sumOfNumbers / n;

            Console.WriteLine($"The average of {nums[0]}, {nums[1]}, {nums[2]}, {nums[3]} is {average}");

            Console.ReadLine();
        }
    }
}
