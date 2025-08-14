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
        private int rollsLeft = 5;

        private Player player1;
        private Player player2;
        private int TurnCount = 0;

        public YatzyGame()
        {
            Console.WriteLine("Enter name for player1: ");
            player1 = new Player(Console.ReadLine());

            Console.WriteLine("Enter name for player2: ");
            player2 = new Player(Console.ReadLine());

            dice = new List<Dice>();
            for (int i = 0; i < 5; i++)
            {
                dice.Add(new Dice());
            }
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to Yatzy!");
            while (TurnCount < 30)
            {
                Player currentPlayer = (TurnCount % 2 == 0) ? player1 : player2;
                Console.WriteLine($"\n {currentPlayer.Name}'s turn!");
                PlayTurn(currentPlayer);
                TurnCount++;
            }

            Console.WriteLine("\n Game Over!");
            Console.WriteLine($"{player1.Name}: {player1.TotalScore} points");
            Console.WriteLine($"{player2.Name}: {player2.TotalScore} points");

            if (player1.TotalScore > player2.TotalScore)
                Console.WriteLine($" {player1.Name} wins!");
            else if (player2.TotalScore > player1.TotalScore)
                Console.WriteLine($" {player2.Name} wins!");
            else
                Console.WriteLine(" It's a tie!");
        }

        public void PlayTurn(Player currentplayer)
        {
            rollsLeft = 5;
            bool[] keep = new bool[5];

            while (rollsLeft > 0)
            {
                Console.WriteLine($"\nRoll {6 - rollsLeft}:");

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
            var categoryNames = new Dictionary<string, string>
            {
                { "1", "Ones" },
                { "2", "Twos" },
                { "3", "Threes" },
                { "4", "Fours" },
                { "5", "Fives" },
                { "6", "Sixes" },
                { "7", "One Pair" },
                { "8", "Two Pair" },
                { "9", "Three of a Kind" },
                { "10", "Four of a Kind" },
                { "11", "Full House" },
                { "12", "Small Straight" },
                { "13", "Large Straight" },
                { "14", "Chance" },
                { "15", "Yatzy" }
            };

            ShowSuggestedCategories(finalDice, currentplayer);

            Console.WriteLine("\nUsed categories:");
            foreach (var cat in currentplayer.UsedCategories)
            {
                Console.WriteLine($"- {categoryNames[cat]}");
            }

            Console.WriteLine("\nRemaining categories:");
            foreach (var kvp in categoryNames)
            {
                if (!currentplayer.HasUsedCategory(kvp.Key))
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }


            string choice;
            while (true)
            {
                Console.WriteLine("\nChoose a category by number:");
                choice = Console.ReadLine();

                if (!categoryNames.ContainsKey(choice))
                {
                    Console.WriteLine("Invalid category. Try again.");
                    continue;
                }

                if (currentplayer.HasUsedCategory(choice))
                {
                    Console.WriteLine("Category already used. Try again.");
                    continue;
                }

                break;
            }

            int score = 0;
            int[] FinalDice = dice.ConvertAll(d => d.Value).ToArray();

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
            }

            currentplayer.MarkCategoryUsed(choice);
            if (int.TryParse(choice, out int numChoice) && numChoice >= 1 && numChoice <= 6)
            {
                currentplayer.AddUpperSectionScore(score);
            }
            else
            {
                currentplayer.AddScore(score);
            }
            Console.WriteLine($"{currentplayer.Name} scored {score} points. Total: {currentplayer.TotalScore}");

            Console.WriteLine("\n--- Scoreboard ---");
            Console.WriteLine($"{player1.Name}: {player1.TotalScore} points");
            Console.WriteLine($"{player2.Name}: {player2.TotalScore} points");
            Console.WriteLine("-------------------");

        }

        private void ShowSuggestedCategories(int[] dice, Player player)
        {
            var suggestions = new Dictionary<string, int>();

            var scoringMethods = new Dictionary<string, Func<int[], int>>
            {
                { "1", YatzyScore.CalculateOnes },
                { "2", YatzyScore.CalculateTwos },
                { "3", YatzyScore.CalculateThrees },
                { "4", YatzyScore.CalculateFours },
                { "5", YatzyScore.CalculateFives },
                { "6", YatzyScore.CalculateSixes },
                { "7", YatzyScore.OnePair },
                { "8", YatzyScore.TwoPair },
                { "9", YatzyScore.ThreeOfAKind },
                { "10", YatzyScore.FourOfAKind },
                { "11", YatzyScore.FullHouse },
                { "12", YatzyScore.SmallStraight },
                { "13", YatzyScore.LargeStraight },
                { "14", YatzyScore.Chance },
                { "15", YatzyScore.Yatzy }
            };

            foreach (var kvp in scoringMethods)
            {
                if (!player.HasUsedCategory(kvp.Key))
                {
                    int score = kvp.Value(dice);
                    if (score > 0)
                    {
                        suggestions[kvp.Key] = score;
                    }
                }
            }
            if (suggestions.Count > 0)
            {
                Console.WriteLine("\nSuggested categories based on your dice:");
                foreach (var suggestion in suggestions.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"{suggestion.Key} - {suggestion.Value} points");
                }
            }
            else
            {
                Console.WriteLine("No scoring options available for this roll.");
            }
        }
    }
}
