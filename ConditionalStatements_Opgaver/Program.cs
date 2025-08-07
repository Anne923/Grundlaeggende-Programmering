namespace ConditionalStatements_Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example AbsoluteValue:
            Console.WriteLine(AbsoluteValue(-392));
            Console.WriteLine(AbsoluteValue(6832));

            // Example DivisibleBy2Or3:
            Console.WriteLine(DivisibleBy2Or3(15, 30));
            Console.WriteLine(DivisibleBy2Or3(2, 90));
            Console.WriteLine(DivisibleBy2Or3(7, 12));

            // Example IfConsistsOfUppercaseLetters:
            Console.WriteLine(IfConsistsOfUppercaseLetters("hej"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("HEJ"));

            // Example IfGreaterThanThirdOne:
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 7, 12 }));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { -5, -8, 50 }));

            // Example IfNumberIsEven:
            Console.WriteLine(IfNumberIsEven(721));
            Console.WriteLine(IfNumberIsEven(1248));

            // Example IfSortedAscending:
            Console.WriteLine(IfSortedAscending(new int[] { 3, 7, 10 }));
            Console.WriteLine(IfSortedAscending(new int[] { 74, 62, 99 }));
        }

        static int AbsoluteValue(int number)
        {
            if (number < 0)
            {
                return -number;
            }
            else
            {
                return number;
            }
        }

        static int DivisibleBy2Or3(int number, int v)
        {
            bool numberDivisible = number % 2 == 0 || number % 3 == 0;
            bool vDivisible = v % 2 == 0 || v % 3 == 0;

            if (numberDivisible && vDivisible)
            {
                return number * v;
            }
            else
            {
                return number + v;
            }
        }

        static bool IfConsistsOfUppercaseLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            foreach (char c in input)
            {
                if (!char.IsUpper(c))
                {
                    return false;
                }
            }

            return true;
        }

        static bool IfGreaterThanThirdOne(int[] numbers)
        {
            if (numbers == null || numbers.Length != 3)
            {
                throw new ArgumentException("Input must be an array of exactly 3 integers.");
            }

            int first = numbers[0];
            int second = numbers[1];
            int third = numbers[2];

            return (first + second > third) || (first * second > third);
        }

        static bool IfNumberIsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IfSortedAscending(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static int 
    }
}
