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

        [Fact]
        public void OnePair_ShouldReturnHighestPair()
        {
            int[] dice = { 3, 3, 5, 5, 6 };
            int expected = 10;
            int actual = YatzyScore.OnePair(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TwoPair_ShouldReturnSumOfHighestPairs()
        {
            int[] dice = { 3, 3, 5, 5, 6 };
            int expected = 16;
            int actual = YatzyScore.TwoPair(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ThreeOfAKind_ShouldReturnTripleValue()
        {
            int[] dice = { 4, 4, 4, 2, 6 };
            int expected = 12;
            int actual = YatzyScore.ThreeOfAKind(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FourOfAKind_ShouldReturnCorrectScore()
        {
            int[] dice = { 6, 6, 6, 6, 2 };
            int expected = 24;
            int actual = YatzyScore.FourOfAKind(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FullHouse_ShouldReturnCorrectScore()
        {
            int[] dice = { 3, 3, 3, 5, 5 };
            int expected = 19;
            int actual = YatzyScore.FullHouse(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SmallStraight_ShouldReturn15()
        {
            int[] dice = { 1, 2, 3, 4, 5 };
            int expected = 15;
            int actual = YatzyScore.SmallStraight(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LargeStraight_ShouldReturn20()
        {
            int[] dice = { 2, 3, 4, 5, 6 };
            int expected = 20;
            int actual = YatzyScore.LargeStraight(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Yatzy_ShouldReturn50()
        {
            int[] dice = { 6, 6, 6, 6, 6 };
            int expected = 50;
            int actual = YatzyScore.Yatzy(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Chance_ShouldReturnSumOfAllDice()
        {
            int[] dice = { 2, 3, 4, 5, 6 };
            int expected = 20;
            int actual = YatzyScore.Chance(dice);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Dice_ShouldHaveValueBetween1And6_AfterCreation()
        {
            Dice dice = new Dice();
            Assert.InRange(dice.Value, 1, 6);
        }

        [Fact]
        public void Dice_ShouldHaveValueBetween1And6_AfterRoll()
        {
            Dice dice = new Dice();
            dice.Roll();
            Assert.InRange(dice.Value, 1, 6);
        }
    }
}
