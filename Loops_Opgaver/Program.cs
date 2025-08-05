using System;

namespace Loops_Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Example MultiplicationTable:
            PrintMultiplicationTable();

            // Example TheBiggestNumber:
            int[] numbers1 = { 190, 291, 145, 209, 280, 200 };
            int[] numbers2 = { -9, -2, -7, -8, -4 };
            Console.WriteLine($"Biggest number: {TheBiggestNumber(numbers1)}");
            Console.WriteLine($"Biggest number: {TheBiggestNumber(numbers2)}");

            // Example Two7sNextToEachOther: (arr er kort for array)
            int[] arr1 = { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 };
            int[] arr2 = { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 };
            Console.WriteLine($"Two7sNextToEachOther(arr1) = {Two7sNextToEachOther(arr1)}");
            Console.WriteLine($"Two7sNextToEachOther(arr2) = {Two7sNextToEachOther(arr2)}");
        }

        static void PrintMultiplicationTable()
        {
            const int size = 10;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }

        static int TheBiggestNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array must not be null or empty.", nameof(numbers));

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }

        static int Two7sNextToEachOther(int[] digits)
        {
            if (digits == null || digits.Length < 2)
                return 0;

            int count = 0;
            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] == 7 && digits[i + 1] == 7)
                    count++;
            }
            return count;
        }
    }
}
