using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Tile
    {
        Position position;

        private Objects[] objects;

        public Tile(int x, int y)
        {
            position.Row = x;
            position.Column = y;
            objects = new Objects[5];
        }

        public char SymbolFor(Objects objects)
        {
            switch (objects)
            {
                case Objects.Empty: return '.';
                case Objects.Player: return '⨀';
                case Objects.Trap: return '☢';
                default: return ' ';
            }
        }
    }
}
