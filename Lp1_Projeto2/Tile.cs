using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Tile
    {
        public Position Position = new Position(0, 0);
        public char symbol1, symbol2, symbol3, symbol4, symbol5;

        public Tile(int x, int y)
        {
            Position.Row = x;
            Position.Column = y;
        }

        public void CreateTile(char FirstSymbol, char SecondSymbol, char ThirdSymbol, char FourthSymbol, char FifthSymbol)
        {
            this.FirstSymbol = FirstSymbol;
            this.SecondSymbol = SecondSymbol;
            this.ThirdSymbol = ThirdSymbol;
            this.FourthSymbol = FourthSymbol;
            this.FifthSymbol = FifthSymbol;
        }

        public char FirstSymbol
        {
            get { return symbol1; }
            set { symbol1 = value; }
        }

        public char SecondSymbol
        {
            get { return symbol2; }
            set { symbol2 = value; }
        }

        public char ThirdSymbol
        {
            get { return symbol3; }
            set { symbol3 = value; }
        }

        public char FourthSymbol
        {
            get { return symbol4; }
            set { symbol4 = value; }
        }

        public char FifthSymbol
        {
            get { return symbol5; }
            set { symbol5 = value; }
        }
    }
}
