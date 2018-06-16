using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Renderer
    {
        public void Render(World world, Player player, int level)
        {
            Menu menu = new Menu();
            Renderer renderer = new Renderer();

            Random random = new Random();
            Exit exit = new Exit();

            string moved = "NOPE";
            int playerX = random.Next(0, 8);
            int playerY = 0;
            int exitX = random.Next(0, 8);
            int exitY = 7;

            world.array[playerX, playerY].Add(player);
            world.array[exitX, exitY].Add(exit);

            while (player.Hp > 0)
            {
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
                                if (world.array[row, column].Contains(exit))
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
                                    $"{level:000}   ┃           Player - " +
                                    $"{player.Symbol}              ┃");
                            }
                            if (row == 1)
                            {
                                Console.Write($"┃    Player HP:         " +
                                    $"{player.Hp:000}   ┃            Empty - " +
                                    $"⚊              ┃");
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
                                    $"⍠              ┃");
                            }
                            if (row == 4)
                            {
                                Console.Write($"┃                             " +
                                    $"┃             Trap - ☢              ┃");
                            }
                            if (row == 5)
                            {
                                Console.Write($"┃                             " +
                                    $"┃             Food - ✚              ┃");
                            }
                            if (row == 6)
                            {
                                Console.Write($"┃                             " +
                                    $"┃      Neutral NPC - ☮              ┃");
                            }
                            if (row == 7)
                            {
                                Console.Write($"┃                             " +
                                    $"┃      Hostile NPC - ☠              ┃");
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

                Console.WriteLine("\n Messages:\n -----------");
                if (moved != "NOPE")
                {
                    Console.WriteLine($"\n  * You moved {moved}.");
                }

                Console.WriteLine("\n -----------\n\n What do I see?\n -----------");
                // Get List of Items at North
                Console.Write($" * NORTH : ");
                if (playerX > 0)
                {
                    if (world.array[playerX - 1, playerY].Count() > 0)
                    {
                        foreach (GameObject thing in world.array[playerX - 1, playerY])
                        {
                            if (thing != player)
                            {
                                Console.Write($" {thing.Name}");
                            }
                        }
                        Console.WriteLine(".");
                    }
                    else
                    {
                        Console.Write(" Empty.\n");
                    }
                }
                else
                {
                    Console.WriteLine(" Wall.");
                }
                // Get List of Items at West
                Console.Write($" * WEST  : ");
                if (playerY > 0)
                {
                    if (world.array[playerX, playerY - 1].Count() > 0)
                    {
                        foreach (GameObject thing in world.array[playerX, playerY - 1])
                        {
                            if (thing != player)
                            {
                                Console.Write($" {thing.Name}");
                            }
                        }
                        Console.WriteLine(".");
                    }
                    else
                    {
                        Console.Write(" Empty.\n");
                    }
                }
                else
                {
                    Console.WriteLine(" Wall.");
                }
                // Get List of Items at East
                Console.Write($" * EAST  : ");
                if (playerY < 7)
                {
                    if (world.array[playerX, playerY + 1].Count() > 0)
                    {
                        foreach (GameObject thing in world.array[playerX, playerY + 1])
                        {
                            if (thing != player)
                            {
                                Console.Write($" {thing.Name}");
                            }
                        }
                        Console.WriteLine(".");
                    }
                    else
                    {
                        Console.Write(" Empty.\n");
                    }
                }
                else
                {
                    Console.WriteLine(" Wall.");
                }
                // Get List of Items at South
                Console.Write($" * SOUTH : ");
                if (playerX < 7)
                {
                    if (world.array[playerX + 1, playerY].Count() > 0)
                    {
                        foreach (GameObject thing in world.array[playerX + 1, playerY])
                        {
                            if (thing != player)
                            {
                                Console.Write($" {thing.Name}");
                            }
                        }
                        Console.WriteLine(".");
                    }
                    else
                    {
                        Console.Write(" Empty.\n");
                    }
                }
                else
                {
                    Console.WriteLine(" Wall.");
                }
                // Get List of Items at current position
                Console.Write($" * HERE  : ");
                if (world.array[playerX, playerY].Count() > 0)
                {
                    foreach (GameObject thing in world.array[playerX, playerY])
                    {
                        if (thing != player)
                        {
                            Console.Write($" {thing.Name}");
                        }
                    }
                    Console.WriteLine(" Empty.");
                }

                Console.WriteLine("\n -----------\n\n Inputs:\n -----------");
                Console.WriteLine("\n  (w) - Move NORTH (a) - Move WEST\n" +
                    "  (d) - Move EAST  (s) - Move SOUTH\n  (q) - Quit Game");
                Console.WriteLine("\n -----------");

                bool choosingKey = true;
                bool choosing2 = true;
                bool choosing3 = true;
                char choice = 'X';
                char choice2 = 'X';

                while (choosingKey)
                {
                    while (choosing2)
                    {
                        string choiceStr = Console.ReadLine();
                        if (choiceStr.Length == 1 && (choiceStr == "w" ||
                            choiceStr == "s" || choiceStr == "a" ||
                            choiceStr == "d" || choiceStr == "q"))
                        {
                            choice = Convert.ToChar(choiceStr);
                            break;
                        }
                        Console.WriteLine("Wrong Inupt, try again...");
                    }
                    switch (choice)
                    {
                        case 'w':
                            if (playerX > 0)
                            {
                                world.array[playerX, playerY].Remove(player);
                                playerX -= 1;
                                world.array[playerX, playerY].Add(player);
                                choosingKey = false;
                                moved = "NORTH";
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 's':
                            if (playerX < 7)
                            {
                                world.array[playerX, playerY].Remove(player);
                                playerX += 1;
                                world.array[playerX, playerY].Add(player);
                                choosingKey = false;
                                moved = "SOUTH";
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 'a':
                            if (playerY > 0)
                            {
                                world.array[playerX, playerY].Remove(player);
                                playerY -= 1;
                                world.array[playerX, playerY].Add(player);
                                choosingKey = false;
                                moved = "WEST";
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 'd':
                            if (playerY < 7)
                            {
                                world.array[playerX, playerY].Remove(player);
                                playerY += 1;
                                world.array[playerX, playerY].Add(player);
                                choosingKey = false;
                                moved = "EAST";
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 'q':
                            Console.WriteLine("Are you sure you want to quit? (y/n)");
                            while (choosing3)
                            {
                                string choiceStr2 = Console.ReadLine();
                                if (choiceStr2.Length == 1 && (choiceStr2 == "y" ||
                                    choiceStr2 == "n"))
                                {
                                    choice2 = Convert.ToChar(choiceStr2);
                                    break;
                                }
                                Console.WriteLine("Wrong Inupt, try again...");
                            }
                            switch (choice2)
                            {
                                case 'y':
                                    Environment.Exit(0);
                                    break;
                                case 'n':
                                    choosing3 = false;
                                    break;
                            }
                            break;
                    }
                }
                player.Hp--;
                if (player.Hp == 0)
                {
                    break;
                }
                Console.Clear();
                if (world.array[playerX, playerY].Contains(player) &&
                    world.array[playerX, playerY].Contains(exit) && player.Hp != 0)
                {
                    level++;
                    Console.Clear();
                    Console.WriteLine($"\nYou've made it to level {level}!" +
                        $"\nPress any Key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    world = new World();
                    renderer.Render(world, player, level);
                }
            }
            Console.Clear();
            Console.WriteLine($"\nYou've died, what a shame...\n" +
                $"You made it till level {level}!");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}