﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {
        private string v;

        public MagicWand(string description)
        {
            Description = description;
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }
    }
}
