using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Tile
    {
        public Position Position { get; set; }
        public string State { get; set; }

        public Tile(int x, int y, State state)
        {
            Position.Row = x;
            Position.Column = y;
            if (state == Lp1_Projeto2.State.Unknown)
            {
                State = "/////";
            }
            if (state == Lp1_Projeto2.State.Known)
            {
                State = ".....";
            }
            if (state == Lp1_Projeto2.State.Exit)
            {
                State = "EXIT!";
            }
        }     
    }
}
