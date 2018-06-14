using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Player
    {
        public float Hp { get; set; }
        public string Symbol { get; set; }

        public Player()
        {
            Hp = 100;
            Symbol = "⛨";
        }
    }
}
