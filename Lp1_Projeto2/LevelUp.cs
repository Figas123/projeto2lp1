using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class that checks if the player is able to progress to the next level
    /// </summary>
    public class LevelUp
    {
        /// <summary>
        /// Checks if the player can progress to the next level
        /// </summary>
        /// <param name="cons">The global constants</param>
        /// <param name="world">The current world</param>
        /// <returns>Returns a true or a false</returns>
        public bool CheckLevelUp(GameCons cons, World world)
        {
            // When the players list has an exit in it this code will be done
            if (world.array[world.playerX, world.playerY].Contains(cons.player) &&
                world.array[world.playerX, world.playerY].Contains(cons.exit) && cons.player.Hp != 0)
            {
                // Increments the level
                cons.level++;
                // Clears the Console
                Console.Clear();
                // Displays an informative message to the user
                Console.WriteLine($"\nYou've made it to level {cons.level}!" +
                    $"\nPress any Key to continue.");
                // Waits for feedback
                Console.ReadKey();
                // Clears the console
                Console.Clear();
                // Returns a "true" so the program can continue to the next level
                return true;
            }
            // Returns a "false" so the current level may continue
            return false;
        }
    }
}
