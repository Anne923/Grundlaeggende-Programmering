namespace Strings_Tests
{
    public class StringsTests
    {
        [Fact]
        public void AddSeparatorShouldReturnCorrectResult()
        {
            // Arrange
            string input = "ABCD";
            string separator = "^";
            string expected = "A^B^C^D^";

            // Act
            string actual = Strings_Opgaver.Program.AddSeparator(input, separator);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsPalindromeShouldReturnTrueForPalindrome()
        {
            // Arrange
            string input = "eye";
            bool expected = true;

            // Act
            bool actual = Strings_Opgaver.Program.IsPalindrome(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsPalindromeShouldReturnFalseForNonPalindrome()
        {
            // Arrange
            string input = "home";
            bool expected = false;

            // Act
            bool actual = Strings_Opgaver.Program.IsPalindrome(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
