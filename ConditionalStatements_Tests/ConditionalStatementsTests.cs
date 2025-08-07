namespace ConditionalStatements_Tests
{
    public class ConditionalStatementsTests
    {
        [Fact]
        public void AbsoluteValueShouldReturnCorrectResult()
        {
            // Arrange
            int expected = 392;
            int input = -392;
            // Actual
            int actual = ConditionalStatements_Opgaver.Program.AbsoluteValue(input);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IfConsistsOfUppercaseLettersShouldReturnFalseForMixedCase()
        {
            // Arrange
            bool expected = false;
            string input = "Hello";

            // Act
            bool actual = ConditionalStatements_Opgaver.Program.IfConsistsOfUppercaseLetters(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IfConsistsOfUppercaseLettersShouldReturnTrueForMixedCase()
        {
            // Arrange
            bool expected = true;
            string input = "EYE";

            // Act
            bool actual = ConditionalStatements_Opgaver.Program.IfConsistsOfUppercaseLetters(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

