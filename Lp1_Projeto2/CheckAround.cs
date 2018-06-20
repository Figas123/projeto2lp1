using System;
using System.Linq;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class that checks what's around the player and informs it
    /// </summary>
    public class CheckAround
    {
        /// <summary>
        /// Checks what's inside neighboring tiles to the player
        /// </summary>
        /// <param name="cons">The global variables</param>
        /// <param name="world">The current world</param>
        public void Check(GameCons cons, World world)
        {
            Console.WriteLine("\n What do I see?\n -----------\n");
            // Get List of Items at North
            Console.Write($"  * NORTH : ");
            // Limits the search so it doenst go outside the matrix
            if (world.playerX > 0)
            {
                /* When theres something inside the list north of the player
                 * go in this if */
                if (world.array[world.playerX - 1, world.playerY].Count() > 0)
                {
                    /* Gos throw every object with the intergace IGameObject
                     * thats inside the list north of the player */
                    foreach (IGameObject thing in world.array[world.playerX - 1, world.playerY])
                    {
                        // Displays the propriety "Name" from the thing
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" {thing.Name}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    // Displays a '.' at the end of the listing
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(".");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                /* When theres nothing inside the list north of the player
                 * go in this if */
                else
                {
                    // Displays "Empty" since the list is empty
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Empty.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            // When the search is outside the matrix go in this else
            else
            {
                // Displays "Wall" since its the limit of the matrix
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Wall.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Get List of Items at West
            Console.Write($"  * WEST  : ");
            // Limits the search so it doenst go outside the matrix
            if (world.playerY > 0)
            {
                /* When theres something inside the list west of the player
                 * go in this if */
                if (world.array[world.playerX, world.playerY - 1].Count() > 0)
                {
                    /* Gos throw every object with the intergace IGameObject
                     * thats inside the list west of the player */
                    foreach (IGameObject thing in world.array[world.playerX, world.playerY - 1])
                    {
                        // Displays the propriety "Name" from the thing
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" {thing.Name}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    // Displays a '.' at the end of the listing
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(".");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                /* When theres nothing inside the list west of the player
                 * go in this if */
                else
                {
                    // Displays "Empty" since the list is empty
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Empty.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            // When the search is outside the matrix go in this else
            else
            {
                // Displays "Wall" since its the limit of the matrix
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Wall.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Get List of Items at East
            Console.Write($"  * EAST  : ");
            // Limits the search so it doenst go outside the matrix
            if (world.playerY < 7)
            {
                /* When theres something inside the list east of the player
                 * go in this if */
                if (world.array[world.playerX, world.playerY + 1].Count() > 0)
                {
                    /* Gos throw every object with the intergace IGameObject
                     * thats inside the list east of the player */
                    foreach (IGameObject thing in world.array[world.playerX, world.playerY + 1])
                    {
                        // Displays the propriety "Name" from the thing
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" {thing.Name}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    // Displays a '.' at the end of the listing
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(".");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                /* When theres nothing inside the list east of the player
                 * go in this if */
                else
                {
                    // Displays "Empty" since the list is empty
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Empty.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            // When the search is outside the matrix go in this else
            else
            {
                // Displays "Wall" since its the limit of the matrix
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Wall.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Get List of Items at South
            Console.Write($"  * SOUTH : ");
            // Limits the search so it doenst go outside the matrix
            if (world.playerX < 7)
            {
                /* When theres something inside the list south of the player
                 * go in this if */
                if (world.array[world.playerX + 1, world.playerY].Count() > 0)
                {
                    /* Gos throw every object with the intergace IGameObject
                     * thats inside the list south of the player */
                    foreach (IGameObject thing in world.array[world.playerX + 1, world.playerY])
                    {
                        // Displays the propriety "Name" from the thing
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" {thing.Name}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    // Displays a '.' at the end of the listing
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(".");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                /* When theres nothing inside the list south of the player
                 * go in this if */
                else
                {
                    // Displays "Empty" since the list is empty
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" Empty.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            // When the search is outside the matrix go in this else
            else
            {
                // Displays "Wall" since its the limit of the matrix
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Wall.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // Get List of Items at current position
            Console.Write($"  * HERE  : ");
            /* When theres something inside the current list of the player
             * besides the player itself go in this if */
            if (world.array[world.playerX, world.playerY].Count > 1)
            {
                /* Gos throw every object with the intergace IGameObject
                 * thats inside the current list of the player */
                foreach (IGameObject thing in world.array[world.playerX, world.playerY])
                {
                    // Excludes the player off the search
                    if (thing != cons.player)
                    {
                        // Displays the propriety "Name" from the thing
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($" {thing.Name}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                // Displays a '.' at the end of the listing
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(".");
                Console.ForegroundColor = ConsoleColor.White;
            }
            // When the only thing inside the list is the player go in this if
            if (world.array[world.playerX, world.playerY].Count == 1)
            {
                // Displays "Empty" since the list is empty besides the player
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" Empty.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("\n -----------");
        }
    }
}
