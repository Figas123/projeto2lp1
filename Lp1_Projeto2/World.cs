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

        public World()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    array[row, column] = new Tile();
                }
            }
        }
    }
}
