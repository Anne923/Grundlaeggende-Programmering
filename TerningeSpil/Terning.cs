using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terninge_Spil
{
    public class Terning
    {
        private static Random rng = new Random();
        
        public int Værdi { get; private set; }

        public void Kast()
        {
            Værdi = rng.Next(1, 7);
        }
    }

}

