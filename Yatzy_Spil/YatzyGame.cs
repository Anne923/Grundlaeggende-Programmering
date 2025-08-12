using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy_Spil
{
    public class YatzyGame
    {
        private List<Dice> dice;
        private int rollsLeft = 3;

        public YatzyGame()
        {
            dice = new List<Dice>();
            for (int i = 0; i < 5; i++)
            {
                dice.Add(new Dice());
            }
        }

        public void PlayTurn()
        {
            rollsLeft = 3;
            bool[] keep = new bool[5];

            while (rollsLeft > 0)
            {
                Console.WriteLine($"\nRoll {4 - rollsLeft}:");

                for (int i = 0; i < dice.Count; i++)
                {
                    if (!keep[i])
                    {
                        dice[i].Roll();
                    }
                    Console.WriteLine($"Dice {i + 1}: {dice[i].Value} {(keep[i] ? "(kept)" : "")}");
                }

                rollsLeft--;

                if (rollsLeft > 0)
                {
                    Console.WriteLine("Enter dice numbers to keep (e.g. 1 3 5), or press Enter to reroll all:");
                    string input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        // Reset keep array
                        Array.Fill(keep, false);

                        foreach (var part in input.Split())
                        {
                            if (int.TryParse(part, out int index) && index >= 1 && index <= 5)
                            {
                                keep[index - 1] = true;
                            }
                        }
                    }
                }
            }

            int[] finalDice = dice.ConvertAll(d => d.Value).ToArray();
            Console.WriteLine("\nFinal dice:");
            Console.WriteLine(string.Join(", ", finalDice));

            Console.WriteLine("\nChoose a scoring category:");
            Console.WriteLine("1 - Ones");
            Console.WriteLine("2 - Twos");
            Console.WriteLine("3 - Threes");
            Console.WriteLine("4 - Fours");
            Console.WriteLine("5 - Fives");
            Console.WriteLine("6 - Sixes");
            Console.WriteLine("7 - One Pair");
            Console.WriteLine("8 - Two Pair");
            Console.WriteLine("9 - Three of a Kind");
            Console.WriteLine("10 - Four of a Kind");
            Console.WriteLine("11 - Full House");
            Console.WriteLine("12 - Small Straight");
            Console.WriteLine("13 - Large Straight");
            Console.WriteLine("14 - Chance");
            Console.WriteLine("15 - Yatzy");

            string choice = Console.ReadLine();
            int score = 0;

            switch (choice)
            {
                case "1": score = YatzyScore.CalculateOnes(finalDice); break;
                case "2": score = YatzyScore.CalculateTwos(finalDice); break;
                case "3": score = YatzyScore.CalculateThrees(finalDice); break;
                case "4": score = YatzyScore.CalculateFours(finalDice); break;
                case "5": score = YatzyScore.CalculateFives(finalDice); break;
                case "6": score = YatzyScore.CalculateSixes(finalDice); break;
                case "7": score = YatzyScore.OnePair(finalDice); break;
                case "8": score = YatzyScore.TwoPair(finalDice); break;
                case "9": score = YatzyScore.ThreeOfAKind(finalDice); break;
                case "10": score = YatzyScore.FourOfAKind(finalDice); break;
                case "11": score = YatzyScore.FullHouse(finalDice); break;
                case "12": score = YatzyScore.SmallStraight(finalDice); break;
                case "13": score = YatzyScore.LargeStraight(finalDice); break;
                case "14": score = YatzyScore.Chance(finalDice); break;
                case "15": score = YatzyScore.Yatzy(finalDice); break;
                default: Console.WriteLine("Invalid choice."); break;
            }

            Console.WriteLine($"You scored {score} points.");
        }
    }
}
