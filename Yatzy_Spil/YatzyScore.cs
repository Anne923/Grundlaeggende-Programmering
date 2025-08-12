using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
