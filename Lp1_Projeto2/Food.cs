using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Food
    {
        public string Symbol { get; set; }
        public string Name { get; set; }

        public Food()
        {
            Symbol = "✚";
            Name = "Potato";
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
