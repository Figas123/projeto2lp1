using System;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to create a World
    /// </summary>
    public class World
    {
        /// <summary>
        /// The Worlds random seed
        /// </summary>
        private static Random random = new Random();
        /// <summary>
        /// The array of Tiles thats the basis for the Worlds grid
        /// </summary>
        public Tile[,] array = new Tile[8, 8];
        /// <summary>
        /// The Players spawn locations X coordenate
        /// </summary>
        public int playerX = random.Next(0, 8);
        /// <summary>
        /// The Players spawn locations y coordenate
        /// </summary>
        public int playerY = 0;
        /// <summary>
        /// The Exits spawn locations X coordenate
        /// </summary>
        public int exitX = random.Next(0, 8);
        /// <summary>
        /// The Exits spawn locations Y coordenate
        /// </summary>
        public int exitY = 7;
        /// <summary>
        /// String that controls the messages related to movement
        /// </summary>
        public string moved = "NOPE";
        /// <summary>
        /// Creates a World
        /// </summary>
        /// <param name="cons">The global constants</param>
        public void CreateWorld(GameCons cons)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    // Creates a List inside all Tiles
                    array[row, column] = new Tile();
                }
            }
            // Adds a player to the world
            array[playerX, playerY].Add(cons.player);
            // Adds a exit to the world
            array[exitX, exitY].Add(cons.exit);
            // Generates a random X coordenate for the map
            int mapX = random.Next(0, 8);
            // Generates a random Y coordenate for the map
            int mapY = random.Next(0, 8);
            // Loop while theres no map in the maps coordenates
            while (array[mapX, mapY].Contains(cons.map) == false)
            {
                /* If theres no exit in the maps coordenates Add a map to the
                 * maps coordenates */
                if (array[mapX, mapY].Contains(cons.exit) == false)
                {
                    array[mapX, mapY].Add(cons.map);
                }
                // Else make new coordenates
                else
                {
                    mapX = random.Next(0, 8);
                    mapY = random.Next(0, 8);
                }
            }
        }
    }
}
