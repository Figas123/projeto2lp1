﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Trap : GameObject
    {
        public float Damage { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }

        public Trap()
        {
            Damage = 5;
            Symbol = "☢";
            Name = "Hole";
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
