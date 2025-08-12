using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Yatzy_Spil
{
    public static class YatzyScore
    {
        public static int CalculateOnes(int[] dice)
        {
            return dice.Where(d => d == 1).Sum();
        }

        public static int CalculateTwos(int[] dice)
        {
            return dice.Where(d => d == 2).Sum();
        }

        public static int CalculateThrees(int[] dice)
        {
            return dice.Where(d => d == 3).Sum();
        }

        public static int CalculateFours(int[] dice)
        {
            return dice.Where(d => d == 4).Sum();
        }

        public static int CalculateFives(int[] dice)
        {
            return dice.Where(d => d == 5).Sum();
        }

        public static int CalculateSixes(int[] dice)
        {
            return dice.Where(d => d == 6).Sum();
        }

        public static int OnePair(int[] dice)
        {
            var groups = dice.GroupBy(d => d)
                             .Where(g => g.Count() >= 2)
                             .OrderByDescending(g => g.Key);

            return groups.Any() ? groups.First().Key * 2 : 0;
        }

        public static int TwoPair(int[] dice)
        {
            var pairs = dice.GroupBy(d => d)
                            .Where(g => g.Count() >= 2)
                            .OrderByDescending(g => g.Key)
                            .Take(2)
                            .ToList();

            return pairs.Count == 2 ? pairs.Sum(p => p.Key * 2) : 0;
        }

        public static int ThreeOfAKind(int[] dice)
        {
            var group = dice.GroupBy(d => d)
                            .FirstOrDefault(g => g.Count() >= 3);

            return group != null ? group.Key * 3 : 0;
        }

        public static int FourOfAKind(int[] dice)
        {
            var group = dice.GroupBy(d => d)
                            .FirstOrDefault(g => g.Count() >= 4);
            return group != null ? group.Key * 4 : 0;
        }

        public static int FullHouse(int[] dice)
        {
            var groups = dice.GroupBy(d => d).ToList();
            var three = groups.FirstOrDefault(g => g.Count() == 3);
            var pair = groups.FirstOrDefault(g => g.Count() == 2);

            if (three != null && pair != null)
                return three.Key * 3 + pair.Key * 2;

            return 0;
        }

        public static int SmallStraight(int[] dice)
        {
            var required = new[] { 1, 2, 3, 4, 5 };
            return required.All(dice.Contains) ? 15 : 0;
        }

        public static int LargeStraight(int[] dice)
        {
            var required = new[] { 2, 3, 4, 5, 6 };
            return required.All(dice.Contains) ? 20 : 0;
        }

        public static int Yatzy(int[] dice)
        {
            return dice.Distinct().Count() == 1 ? 50 : 0;
        }

        public static int Chance(int[] dice)
        {
            return dice.Sum();
        }

    }
}
