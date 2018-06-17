using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Renderer
    {
        public void Render(GameCons cons, World world)
        {
            Console.Clear();
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

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    if (column == 0)
                    {
                        Console.Write("┃ ");
                    }
                    foreach (GameObject thing in world.array[row, column])
                    {
                        Console.Write(thing.ToString());
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
                                Console.Write("⚊");
                            }
                        }
                    }
                    if (column < 7)
                    {
                        Console.Write(" - ");
                    }
                    if (column == 7)
                    {
                        if (row == 0)
                        {
                            Console.Write($"┃    Current Level:     " +
                                $"{cons.level:000}   ┃           Pla" +
                                $"yer - {cons.player.Symbol}              ┃");
                        }
                        if (row == 1)
                        {
                            Console.Write($"┃    Player HP:         " +
                                $"{cons.player.Hp:000}   ┃          " +
                                $"  Empty - ⚊              ┃");
                        }
                        if (row == 2)
                        {
                            Console.Write($"┃    Weapon:    " +
                                $"Rusty Spoon   ┃       Unexplored - " +
                                $"░              ┃");
                        }
                        if (row == 3)
                        {
                            Console.Write($"┃    Inventory:        " +
                                $"099%   ┃              Map - " +
                                $"{cons.map.Symbol}              ┃");
                        }
                        if (row == 4)
                        {
                            Console.Write($"┃                             ┃" +
                                $"             Trap - {cons.trap.Symbol}   " +
                                $"           ┃");
                        }
                        if (row == 5)
                        {
                            Console.Write($"┃                             ┃" +
                                $"             Food - {cons.food.Symbol}   " +
                                $"           ┃");
                        }
                        if (row == 6)
                        {
                            Console.Write($"┃                             ┃" +
                                $"      Neutral NPC - " +
                                $"{cons.npc.SymbolNeutral}              ┃");
                        }
                        if (row == 7)
                        {
                            Console.Write($"┃                             ┃" +
                                $"      Hostile NPC - " +
                                $"{cons.npc.SymbolHostile}              ┃");
                        }
                        Console.Write("\n");
                    }
                }
                if (row < 7)
                {
                    Console.Write("┃ ");
                    Console.WriteLine("   |          |          |      " +
                        "    |          |          |          |        " +
                        "  |    ┃                             ┃        " +
                        "                            ┃");
                }
                if (row == 7)
                {
                    Console.WriteLine($"┃                              " +
                        $"                                             " +
                        $"           ┃                             ┃   " +
                        $"                                 ┃");
                    Console.WriteLine($"┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" +
                        $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" +
                        $"━━━━━━━━━━━┻━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┻━━━" +
                        $"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                }
            }
        }
    }
}