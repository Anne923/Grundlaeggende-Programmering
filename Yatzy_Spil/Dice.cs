using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy_Spil
{
    public class Dice
    {
        private static Random rng = new Random();

        public int Value { get; private set; }
        public void Roll()
        {
            Value = rng.Next(1, 7);
        }

        public Dice()
        {
            Roll(); // Betyder at den selv ruller en værdi ved oprettelse
        }
    }
}
