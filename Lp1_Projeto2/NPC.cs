using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class NPC : IGameObject
    {
        public bool Hostile { get; set; }
        public float HP { get; set; }
        public float AP { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }

        public NPC(bool Hostile)
        {
            this.Hostile = Hostile;
            HP = 20;
            AP = 3;
            if (Hostile)
            {
                Symbol = "☠";
                Name = "Hostile NPC";
            }
            else
            {
                Symbol = "☮";
                Name = "Neutral NPC";
            }
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
