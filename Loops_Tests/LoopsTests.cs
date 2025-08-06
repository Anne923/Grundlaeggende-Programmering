using Microsoft.VisualStudio.TestPlatform.TestHost;
using Loops_Opgaver;

namespace Loops_Tests
{
    public class LoopsTests
    {
        [Fact]
        public void TheBiggestNumberShouldReturnCorrectResult()
        {
            // Arrange
            int expected = 291;
            int[] input = { 190, 291, 145, 209, 280, 200 };
            // actual 
            int actual = Loops_Opgaver.Program.TheBiggestNumber(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
