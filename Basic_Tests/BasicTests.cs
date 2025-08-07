namespace Basic_Tests
{
    public class BasicTests
    {
        [Fact]
        public void AddAndMultiplyShouldReturnCorrectResult()
        {
            // Arrange
            int a = 2, b = 3, c = 4;
            int expected = (a + b) * c;
            // Act
            int result = Basic_Opgaver.Program.AddAndMultiply(a, b, c);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ElementaryOperationsShouldReturnCorrectResultsForPositiveIntegers()
        {
            // Arrange
            int a = 10;
            int b = 2;
            List<int> expected = new List<int> { 12, 8, 20, 5 };

            // Act
            List<int> actual = Basic_Opgaver.Program.ElementaryOperations(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ElementaryOperationsShouldExcludeDivisionWhenDividingByZero()
        {
            // Arrange
            int a = 10;
            int b = 0;
            List<int> expected = new List<int> { 10, 10, 0 };

            // Act
            List<int> actual = Basic_Opgaver.Program.ElementaryOperations(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }


    }
}
