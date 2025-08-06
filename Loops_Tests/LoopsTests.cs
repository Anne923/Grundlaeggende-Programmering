using Microsoft.VisualStudio.TestPlatform.TestHost;
using Loops_Opgaver;
using System.Diagnostics.CodeAnalysis;

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
            // Actual 
            int actual = Loops_Opgaver.Program.TheBiggestNumber(input);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Two7sNextToEachOtherShouldReturnTrue()
        {
            // Arrange
            int expected = 1;
            int[] input = { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 };
            // Actual
            int actual = Loops_Opgaver.Program.Two7sNextToEachOther(input);
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ThreeIncreasingAdjacentShouldReturnTrue()
        {
            // Arrange
            bool expected = true;
            int[] input = { 45, 23, 44, 68, 65, 70, 80, 81, 82 };
            // Actual
            bool actual = Loops_Opgaver.Program.ThreeIncreasingAdjacent(input);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
