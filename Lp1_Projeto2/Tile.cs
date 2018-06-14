using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class Tile : List<Object>
    {
        public string symbol1, symbol2, symbol3, symbol4, symbol5;

        public Tile() : base()
        {
        }

        public void CreateTile(string FirstSymbol, string SecondSymbol, string ThirdSymbol, string FourthSymbol, string FifthSymbol)
        {
            this.FirstSymbol = FirstSymbol;
            this.SecondSymbol = SecondSymbol;
            this.ThirdSymbol = ThirdSymbol;
            this.FourthSymbol = FourthSymbol;
            this.FifthSymbol = FifthSymbol;
        }

        public string FirstSymbol
        {
            get { return symbol1; }
            set { symbol1 = value; }
        }

        public string SecondSymbol
        {
            get { return symbol2; }
            set { symbol2 = value; }
        }

        public string ThirdSymbol
        {
            get { return symbol3; }
            set { symbol3 = value; }
        }

        public string FourthSymbol
        {
            get { return symbol4; }
            set { symbol4 = value; }
        }

        public string FifthSymbol
        {
            get { return symbol5; }
            set { symbol5 = value; }
        }
    }
}
