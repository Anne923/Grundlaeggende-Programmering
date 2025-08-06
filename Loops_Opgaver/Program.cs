using System;

namespace Loops_Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine($"7sNextToEachOther1 = {Two7sNextToEachOther(arr1)}");
            Console.WriteLine($"7sNextToEachOther2 = {Two7sNextToEachOther(arr2)}");

            // Example ThreeIncreasingAdjacent:
            int[] sequence1 = { 1, 2, 3, 4, 5 };
            int[] sequence2 = { 5, 6, 7, 8, 9 };
            int[] sequence3 = { 1, 3, 2, 4, 5 };
            Console.WriteLine($"Saetning1 = {ThreeIncreasingAdjacent(sequence1)}");
            Console.WriteLine($"Saetning2 = {ThreeIncreasingAdjacent(sequence2)}");
            Console.WriteLine($"Saetning3 = {ThreeIncreasingAdjacent(sequence3)}");

            // Example SieveOfEratosthenes:
            int n = 30;
            int primeCount = SieveOfEratosthenes(n);
            Console.WriteLine($"Number of primenumbers to {n} = {primeCount}");

            // Example ExtractString:
            Console.WriteLine(ExtractString("##abc##def"));
            Console.WriteLine(ExtractString("12###78"));
            Console.WriteLine(ExtractString("gar##d#en"));
            Console.WriteLine(ExtractString("++##--##++"));
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

        static bool ThreeIncreasingAdjacent(int[] numbers)
        {
            if (numbers == null || numbers.Length < 3)
                return false;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i + 1] == numbers[i] + 1 &&
                    numbers[i + 2] == numbers[i + 1] + 1)
                {
                    return true;
                }
            }
            return false;
        }

        static int SieveOfEratosthenes(int n)
        {
            if (n < 2) return 0;
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
                isPrime[i] = true;
            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int multiple = p * p; multiple <= n; multiple += p)
                    {
                        isPrime[multiple] = false;
                    }
                }
            }
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                    count++;
            }
            return count;
        }
        
        static string ExtractString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            int first = input.IndexOf("##");
            if (first == -1)
                return string.Empty;

            int second = input.IndexOf("##", first + 2);
            if (second == -1)
                return string.Empty;

            
            if (second == first + 2)
                return string.Empty;

            return input.Substring(first + 2, second - (first + 2));
        }
    }
}
