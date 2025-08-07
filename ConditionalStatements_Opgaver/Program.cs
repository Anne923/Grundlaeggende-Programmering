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
    }
}
