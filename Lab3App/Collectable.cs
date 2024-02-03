using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable
    {
        public string Description { get; set; }  
        public CollectionBoard Board = new CollectionBoard();
        public virtual void AddMe(List<Collectable> items) 
        {
            items.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!!");
        }
        public virtual void Display() { }
    }
}
