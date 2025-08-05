namespace C__Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example ElementaryOperations:

            foreach (var item in ElementaryOperations(3, 2))
            {
                Console.WriteLine(item);
            }

            // Example AddAndMultiply:
            int result = AddAndMultiply(2, 3, 4);
            Console.WriteLine($"Result: {result}");

            // Example CtoF:
            Console.WriteLine(CtoF(0));
            Console.WriteLine(CtoF(100));
            Console.WriteLine(CtoF(-300));

            // Example IsResultTheSame:
            Console.WriteLine(IsResultTheSame(5 + 5, 4 + 6));
            Console.WriteLine(IsResultTheSame(4 - 5, 7 + 8));

            // Example ModuloOperations:
            Console.WriteLine(ModuloOperations(8, 5, 2));

            // Example TheCubeOf:
            Console.WriteLine(TheCubeOf(2));
            Console.WriteLine(TheCubeOf(-5.5));

            // Example SwapTwoNumbers:
            Console.WriteLine(SwapTwoNumbers(87, 45));
            Console.WriteLine(SwapTwoNumbers(-13, 2));
        }

        // Adds the first two numbers and multiplies the sum by the third number
        static int AddAndMultiply(int a, int b, int c)
        {
            return (a + b) * c;
        }

        static List<int> ElementaryOperations(int a, int b)
        {
            List<int> results = new List<int>();
            results.Add(a + b); // Addition
            results.Add(a - b); // Subtraction
            results.Add(a * b); // Multiplication
            if (b != 0)
            {
                results.Add(a / b); // Division
            }
            return results;
        }

        static string CtoF(double celsius)
        {
            if (celsius < -271.15)
            {
                return "Invalid temperature: below absolute zero.";
            }
            double fahrenheit = (celsius * 9 / 5) + 32;
            return $"T = {fahrenheit}F";

        }

        static bool IsResultTheSame(double result1, double result2)
        {
            return result1 == result2;
        }

        static int ModuloOperations(int a, int b, int c)
        {
            if (b == 0 || c == 0)
                throw new ArgumentException("Modulo by zero is not allowed.");
            return (a % b) % c;
        }

        
        static double TheCubeOf(double number)
        {
            return number * number * number;
        }

        static string SwapTwoNumbers(int a, int b)
        {
            int beforeA = a, beforeB = b;
            int temp = a;
            a = b;
            b = temp;
            return $"Before: a = {beforeA}, b = {beforeB}; After: a = {a}, b = {b}";
        }
    }
}
