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

            // Example StringInReverseOrder:
            Console.WriteLine(StringInReverseOrder("Hello"));

            // Example NumberOfWords:
            Console.WriteLine(NumberOfWords("This is a test string."));

            // Example RevertWordsOrder:
            Console.WriteLine(RevertWordsOrder("John Doe."));
            Console.WriteLine(RevertWordsOrder("A. B. C"));
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

        static string StringInReverseOrder(string input)
        {
            if (input == null)
                return "null";
            var result = new System.Text.StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Append(input[i]);
            }
            return result.ToString();
        }

        static string NumberOfWords(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "0";
            // Splitter ordene fra mellemrummene, så den kun tager ordene.
            var words = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length.ToString();
        }

        static string RevertWordsOrder(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            var words = input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
