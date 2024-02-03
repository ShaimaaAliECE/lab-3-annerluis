using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Tool : Collectable
    {
        public virtual void DoAction() 
        {
            Console.WriteLine($"{Description} is used");
        }
        public override void AddMe(List<Collectable> items)
        {
            base.AddMe(items); 
            DoAction();
        }
    }
}
