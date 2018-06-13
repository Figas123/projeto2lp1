using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class World
    {
        public Tile[,] tile;

        public World()
        {
            tile = new Tile[8, 8];

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    tile[row, column] = new Tile(row, column);
                    tile[row, column].CreateTile('/', '/', '/', '/', '/');
                }
            }
        }
    }
}
