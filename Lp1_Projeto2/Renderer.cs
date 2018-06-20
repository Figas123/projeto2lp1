using System;
using System.Linq;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to display the World to the user
    /// </summary>
    public class Renderer
    {
        /// <summary>
        /// Displays the world to the user
        /// </summary>
        /// <param name="cons">The global constants</param>
        /// <param name="world">The current world</param>
        public void Render(GameCons cons, World world)
        {
            // Clears the console
            Console.Clear();
            // Building a chart around the World
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" +
                $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━" +
                $"━━━━━━━━━━━━━━━━━━━━━━━━━┳━━━━━━━━━━━━━━━━━━━━━━━━━━━" +
                $"━━━━━━━━━┓");
            Console.WriteLine($"┃                                    Ro" +
                $"gueLike                                         ┃    " +
                $"        Stats            ┃                Legend     " +
                $"         ┃");
            Console.WriteLine($"┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" +
                $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━╋━━━━" +
                $"━━━━━━━━━━━━━━━━━━━━━━━━━╋━━━━━━━━━━━━━━━━━━━━━━━━━━━" +
                $"━━━━━━━━━┫");
            Console.WriteLine($"┃                                      " +
                $"                                                ┃    " +
                $"                         ┃                           " +
                $"         ┃");
            Console.ForegroundColor = ConsoleColor.White;
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    /* Checks if theres a Tile wich contains a Player on the
                     * neighboring Tiles of the current Tile */
                    if ((row > 0 && world.array[row - 1, column].Contains(cons.player)) ||
                        (row < 7 && world.array[row + 1, column].Contains(cons.player)) ||
                        (column > 0 && world.array[row, column - 1].Contains(cons.player)) ||
                        (column < 7 && world.array[row, column + 1].Contains(cons.player)) ||
                        world.array[row, column].Contains(cons.player))
                    {
                        // Makes the current Tile visable
                        world.array[row, column].IsVisable = true;
                    }
                    if (column == 0)
                    {
                        // Building a chart around the World
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("┃ ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    // If the Tile is visable
                    if (world.array[row, column].IsVisable)
                    {
                        // If the Tile contain a Player
                        if (world.array[row, column].Contains(cons.player))
                        {
                            // Displays the Players ToString()
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(cons.player.ToString());
                            Console.ForegroundColor = ConsoleColor.White;
                            /* Gos throw every object with the intergace IGameObject
                             * thats inside the current list */
                            foreach (IGameObject thing in world.array[row, column])
                            {
                                // Excludes the Player off the things
                                if (thing != cons.player)
                                {
                                    // Displays the things ToString()
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(thing.ToString());
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                        // If the Tile doesnt contain a Player
                        if (world.array[row, column].Contains(cons.player) == false)
                        {
                            /* Gos throw every object with the intergace IGameObject
                             * thats inside the current list */
                            foreach (IGameObject thing in world.array[row, column])
                            {
                                // Displays the things ToString()
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write(thing.ToString());
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        // If the current Tile has less than 4 objects do this code
                        if (world.array[row, column].Count() < 4)
                        {
                            // Excludes the number of objects inside the Tile from this for
                            for (int i = 4 - world.array[row, column].Count(); i > 0; i--)
                            {
                                // If theres an Exit inside the Tile
                                if (world.array[row, column].Contains(cons.exit))
                                {
                                }
                                // If theres no Exit inside the Tile
                                else
                                {
                                    // Displays a "Empty" Symbol
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("⚊");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
                    // If the Tile isnt visable
                    if (world.array[row, column].IsVisable == false)
                    {
                        // Display "Unexplored" Symbols
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("░░░░");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (column < 7)
                    {
                        // Displays a separation between the Tiles
                        Console.Write(" - ");
                    }
                    if (column == 7)
                    {
                        if (row == 0)
                        {
                            // Building a chart around the World
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃    Current Level:     " +
                                $"{cons.level:000}   ┃           Pla" +
                                $"yer - {cons.player.Symbol}              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 1)
                        {
                            // Building a chart around the World
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃    Player HP:         " +
                                $"{cons.player.Hp:000}   ┃          " +
                                $"  Empty - ⚊              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 2)
                        {
                            // Building a chart around the World
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃    Weapon:    " +
                                $"Rusty Spoon   ┃       Unexplored - " +
                                $"░              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 3)
                        {
                            // Building a chart around the World
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃    Inventory:        " +
                                $"099%   ┃              Map - " +
                                $"{cons.map.Symbol}              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 4)
                        {
                            // Building a chart around the World
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃                             ┃" +
                                $"             Trap - {cons.trap.Symbol}   " +
                                $"           ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 5)
                        {
                            // Building a chart around the World
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃                             ┃" +
                                $"             Food - {cons.food.Symbol}   " +
                                $"           ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 6)
                        {
                            // Building a chart around the World
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃                             ┃" +
                                $"      Neutral NPC - " +
                                $"{cons.npcN.Symbol}              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 7)
                        {
                            // Building a chart around the World
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃                             ┃" +
                                $"      Hostile NPC - " +
                                $"{cons.npcH.Symbol}              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Write("\n");
                    }
                }
                if (row < 7)
                {
                    // Building a chart around the World
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("┃ ");
                    Console.ForegroundColor = ConsoleColor.White;
                    // Displays a separation between the Tiles
                    Console.Write("   |          |          |      " +
                        "    |          |          |          |        " +
                        "  |");
                    // Building a chart around the World
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("    ┃                           " +
                        "  ┃                                    ┃");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (row == 7)
                {
                    // Building a chart around the World
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"┃                              " +
                        $"                                             " +
                        $"           ┃                             ┃   " +
                        $"                                 ┃");
                    Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" +
                        $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" +
                        $"━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━" +
                        $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}