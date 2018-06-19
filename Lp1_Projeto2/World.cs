using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class World
    {
        private static Random random = new Random();
        
        public Tile[,] array = new Tile[8, 8];

        public int playerX = random.Next(0, 8);
        public int playerY = 0;
        public int exitX = random.Next(0, 8);
        public int exitY = 7;
        public string moved = "NOPE";

        public void CreateWorld(GameCons cons)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    array[row, column] = new Tile();
                }
            }
            array[playerX, playerY].Add(cons.player);
            array[exitX, exitY].Add(cons.exit);
            int mapX = random.Next(0, 8);
            int mapY = random.Next(0, 8);
            while (array[mapX, mapY].Contains(cons.map) == false)
            {
                if (array[mapX, mapY].Contains(cons.exit) == false)
                {
                    array[mapX, mapY].Add(cons.map);
                }
                else
                {
                    mapX = random.Next(0, 8);
                    mapY = random.Next(0, 8);
                }
            }
        }
    }
}
