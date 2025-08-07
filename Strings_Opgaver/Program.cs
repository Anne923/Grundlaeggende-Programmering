namespace Strings_Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example AddSeparator:
            Console.WriteLine(AddSeparator("ABCD", "^"));
            Console.WriteLine(AddSeparator("chocolate", "-"));

            // Example IsPalindrome:
            Console.WriteLine(IsPalindrome("eye"));
            Console.WriteLine(IsPalindrome("home"));

            // Example LengthOfAString:
            Console.WriteLine(LengthOfAString("Computer"));
        }

        static string AddSeparator(string input, string separator)
        {
            if (string.IsNullOrEmpty(input) || separator == null)
                return input;

            var result = new System.Text.StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[i]);
                result.Append(separator);
            }

            return result.ToString();
        }

        static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }

        static string LengthOfAString(string input)
        {
            if (input == null)
                return "null";
            return input.Length.ToString();
        }
    }
}
