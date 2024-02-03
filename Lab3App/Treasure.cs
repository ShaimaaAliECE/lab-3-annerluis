using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        public int Score { get; set; }
        public override void AddMe(List<Collectable> items)
        {
            base.AddMe(items);
            UpdateTotalScore();
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
        }
    }
}
