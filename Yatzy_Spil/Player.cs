using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy_Spil
{
    public class Player
    {
        public string Name { get; }
        public int TotalScore { get; private set;  }

        public int UpperSectionScore { get; private set; }
        public bool BonusAwarded { get; private set; }

        public HashSet<string> UsedCategories { get; }

        public Player (string name)
        {
            Name = name;
            TotalScore = 0;
            UsedCategories = new HashSet<string>();
        }

        public void AddScore(int score)
        {
            TotalScore += score; 
        }

        public bool HasUsedCategory(string categoryNumber)
        {
            return UsedCategories.Contains(categoryNumber);
        }

        public void MarkCategoryUsed(string categoryNumber)
        {
            UsedCategories.Add(categoryNumber);
        }

        public void AddUpperSectionScore(int score)
        {
            UpperSectionScore += score;
            if (!BonusAwarded && UpperSectionScore >= 63 ) 
            {
                TotalScore += 50;
                BonusAwarded = true;
                Console.WriteLine($"{Name} has been awarded a 50-point bonus for the upper section!");
            }
        }

    }
}
