using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class Renderer
    {
        public void Render(GameCons cons, World world)
        {
            Console.Clear();
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
                    // Check what tiles are visable
                    if ((row > 0 && world.array[row - 1, column].Contains(cons.player)) ||
                        (row < 7 && world.array[row + 1, column].Contains(cons.player)) ||
                        (column > 0 && world.array[row, column - 1].Contains(cons.player)) ||
                        (column < 7 && world.array[row, column + 1].Contains(cons.player)) ||
                        world.array[row, column].Contains(cons.player))
                    {
                        world.array[row, column].isVisable = true;
                    }

                    if (column == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("┃ ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (world.array[row, column].isVisable)
                    {
                        foreach (IGameObject thing in world.array[row, column])
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(thing.ToString());
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (world.array[row, column].Count() < 4)
                        {
                            for (int i = 4 - world.array[row, column].Count(); i > 0; i--)
                            {
                                if (world.array[row, column].Contains(cons.exit))
                                {

                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("⚊");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
                    if (world.array[row, column].isVisable == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("░░░░");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (column < 7)
                    {
                        Console.Write(" - ");
                    }
                    if (column == 7)
                    {
                        if (row == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃    Current Level:     " +
                                $"{cons.level:000}   ┃           Pla" +
                                $"yer - {cons.player.Symbol}              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃    Player HP:         " +
                                $"{cons.player.Hp:000}   ┃          " +
                                $"  Empty - ⚊              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃    Weapon:    " +
                                $"Rusty Spoon   ┃       Unexplored - " +
                                $"░              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃    Inventory:        " +
                                $"099%   ┃              Map - " +
                                $"{cons.map.Symbol}              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃                             ┃" +
                                $"             Trap - {cons.trap.Symbol}   " +
                                $"           ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃                             ┃" +
                                $"             Food - {cons.food.Symbol}   " +
                                $"           ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"┃                             ┃" +
                                $"      Neutral NPC - " +
                                $"{cons.npcN.Symbol}              ┃");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (row == 7)
                        {
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("┃ ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("   |          |          |      " +
                        "    |          |          |          |        " +
                        "  |");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("    ┃                           " +
                        "  ┃                                    ┃");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (row == 7)
                {
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