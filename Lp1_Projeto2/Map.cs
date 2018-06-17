using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Map : GameObject
    {
        public string Symbol { get; set; }
        public string Name { get; set; }

        public Map()
        {
            Symbol = "⍠";
            Name = "Map";
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
