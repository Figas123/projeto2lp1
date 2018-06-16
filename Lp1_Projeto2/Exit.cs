using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Exit : GameObject
    {
        public string Name { get; set; }

        public Exit()
        {
            Name = "Exit";
        }

        public override string ToString()
        {
            return "E X I T ";
        }
    }
}
