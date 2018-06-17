using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class NPC
    {
        public float HP { get; set; }
        public float AP { get; set; }
        public bool Hostile { get; set; }
        public string Symbol { get; set; }
        public string SymbolNeutral { get; set; }
        public string SymbolHostile { get; set; }
        public string Name { get; set; }

        public NPC()
        {
            Random random = new Random();

            int value = random.Next(0, 2);
            if (value == 0)
            {
                Hostile = false;
                Symbol = "☮";
                Name = "Neutral NPC";
            }
            else
            {
                Hostile = true;
                Symbol = "☠";
                Name = "Hostile NPC";
            }
            HP = 20;
            AP = 3;
            SymbolNeutral = "☮";
            SymbolHostile = "☠";
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
