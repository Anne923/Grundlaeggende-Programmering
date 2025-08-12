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
        private int rollsleft = 3;
        public YatzyGame()
        {
            dice = new List<Dice>();
            for (int i = 0; i < 5; i++)
            {
                dice.Add(new Dice());
            }
            rollsleft = 0;
        }
        public void RollDice()
        {
            foreach (var die in dice)
            {
                die.Roll();
            }
            rollsleft++;
        }
        public int[] GetDiceValues()
        {
            return dice.Select(d => d.Value).ToArray();
        }
        public int GetCurrentRoll()
        {
            return rollsleft;
        }
    }
}
