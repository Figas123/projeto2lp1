using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class Food : IGameObject
    {
        public string Symbol { get; set; }
        public string Name { get; set; }

        public Food()
        {
            Symbol = "✚";
            Name = "Food";
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
