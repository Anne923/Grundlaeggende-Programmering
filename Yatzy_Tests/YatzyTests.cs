using Yatzy_Spil;

namespace Yatzy_Tests
{
    public class YatzyTests
    {
        [Fact]
        public void CalculateOnes_ShouldReturnCorrectSum()
        {
            int[] dice = { 1, 2, 1, 4, 1 };
            int expected = 3;

            int actual = YatzyScore.CalculateOnes(dice);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateTwos_ShouldReturnCorrectSum()
        {
            int[] dice = { 2, 2, 3, 4, 5 };
            int expected = 4;
            int actual = YatzyScore.CalculateTwos(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateThrees_ShouldReturnCorrectSum()
        {
            int[] dice = { 3, 3, 3, 4, 5 };
            int expected = 9;
            int actual = YatzyScore.CalculateThrees(dice);
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void CalculateFours_ShouldReturnCorrectSum()
        {
            int[] dice = { 4, 4, 5, 6, 1 };
            int expected = 8;
            int actual = YatzyScore.CalculateFours(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateFives_ShouldReturnCorrectSum()
        {
            int[] dice = { 5, 5, 2, 3, 1 };
            int expected = 10;
            int actual = YatzyScore.CalculateFives(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateSixes_ShouldReturnCorrectSum()
        {
            int[] dice = { 6, 6, 2, 3, 4 };
            int expected = 12;
            int actual = YatzyScore.CalculateSixes(dice);
            Assert.Equal(expected, actual);
        }
    }
}
