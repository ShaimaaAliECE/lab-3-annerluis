﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool
    {
        private string v;

        public Axe(string description)
        {
            Description = description;
        }

        public override void Display()
        {
            Console.WriteLine($"Axe {Description} is displayed");
        }
        public override void DoAction()
        {
            Console.WriteLine("Axe is used");
        }
    }
}
