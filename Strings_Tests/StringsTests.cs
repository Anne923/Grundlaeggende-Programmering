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
    }
}
