using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class that shows the messages
    /// </summary>
    public class Messages
    {
        /// <summary>
        /// Shows the messages to the player
        /// </summary>
        /// <param name="cons">The global constants</param>
        /// <param name="world">The current world</param>
        public void ShowMessages(GameCons cons, World world)
        {
            Console.WriteLine("\n Messages:\n -----------");
            // Shows the messages corresponding to the players movement
            if (world.moved != "NOPE")
            {
                Console.WriteLine($"\n  * You moved {world.moved}.");
            }
            Console.WriteLine("\n -----------");
        }
    }
}
