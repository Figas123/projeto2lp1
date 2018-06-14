using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Trap
    {
        public float Damage { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public Trap(float dam, string name)
        {
            Damage = dam;
            Name = name;
            Symbol = "☠";
        }
    }
}
