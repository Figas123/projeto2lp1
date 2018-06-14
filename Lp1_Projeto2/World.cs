using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class World
    {
        public Tile[,] array = new Tile[8, 8];
        public List<Object> list = new List<Object>();

        public Empty empty = new Empty();
        public Unknown unknown = new Unknown();

        public World()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    array[row, column] = new Tile();
                    array[row, column].FirstSymbol = unknown.Symbol;
                    array[row, column].SecondSymbol = unknown.Symbol;
                    array[row, column].ThirdSymbol = unknown.Symbol;
                    array[row, column].FourthSymbol = unknown.Symbol;
                    array[row, column].FifthSymbol = unknown.Symbol;
                }
            }
        }
    }
}
