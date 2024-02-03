using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int Value { get; set; }
        public Coin(string description, int score, int value)
        {
            Description = description;
            Score = score;
            Value = value;
        }
        public override void AddMe(List<Collectable> items)
        {
            base.AddMe(items); 
            UpdateTotalValue();
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }
        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
        }
        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}
