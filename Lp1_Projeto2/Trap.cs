using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Trap : IExist
    {
        public int X { get; set; }
        public int Y { get; set; }
        public float Damage { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public Trap(int x, int y, float dam, string name)
        {
            X = x;
            Y = y;
            Damage = dam;
            Name = name;
        }
    }
}
