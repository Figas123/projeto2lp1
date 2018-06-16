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
            Empty empty = new Empty();

            bool game = true;
            string moved = "NOPE";
            int playerX = random.Next(0, 8);
            int playerY = 0;
            int exitX = random.Next(0, 8);
            int exitY = 7;

            world.array[playerX, playerY].CreateTile(player.Symbol, empty.Symbol,
                empty.Symbol, empty.Symbol, empty.Symbol);
            world.array[playerX, playerY].Add(player);

            world.array[exitX, exitY].CreateTile("E ", "X ", "I ", "T ", "! ");
            world.array[exitX, exitY].Add(exit);

            while (game)
            {
                for (int row = 0; row < 8; row++)
                {
                    for (int column = 0; column < 8; column++)
                    {
                        Console.Write($"{world.array[row, column].FirstSymbol}" +
                            $"{world.array[row, column].SecondSymbol}" +
                            $"{world.array[row, column].ThirdSymbol}" +
                            $"{world.array[row, column].FourthSymbol}" +
                            $"{world.array[row, column].FifthSymbol}");
                        if (column < 7)
                        {
                            Console.Write(" - ");
                        }
                        if (column == 7)
                        {
                            Console.Write("\n");
                        }
                    }

                    if (row < 7)
                    {
                        Console.WriteLine("    |            |            |    " +
                            "        |            |            |            |            |");
                    }
                }

                Console.WriteLine("\nMessages:\n-----------");
                if (moved != "NOPE")
                {
                    Console.WriteLine($"\n* You moved {moved}.");
                }
                Console.WriteLine("\n-----------\n\nInputs:\n-----------");
                Console.WriteLine("\n(w) - Move NORTH (a) - Move WEST\n(d) - Move EAST  (s) - Move SOUTH\n(q) - Quit Game");
                Console.WriteLine("\n-----------\n\nStats\n----------");
                Console.WriteLine("\nPlayer's HP: " + player.Hp + "\n");
                Console.WriteLine("Current Lvl: " + level + "\n\n----------");
                bool choosing = true;
                bool choosing2 = true;
                bool choosing3 = true;
                char choice = 'X';
                char choice2 = 'X';

                while (choosing)
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
                                world.array[playerX, playerY].CreateTile(
                                    empty.Symbol, empty.Symbol, empty.Symbol,
                                    empty.Symbol, empty.Symbol);
                                playerX -= 1;
                                world.array[playerX, playerY].Add(player);
                                world.array[playerX, playerY].CreateTile(
                                    player.Symbol, empty.Symbol, empty.Symbol,
                                    empty.Symbol, empty.Symbol);
                                choosing = false;
                                moved = "NORTH";

                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 's':
                            if (playerX < 7)
                            {
                                world.array[playerX, playerY].Remove(player);
                                world.array[playerX, playerY].CreateTile(
                                    empty.Symbol, empty.Symbol, empty.Symbol,
                                    empty.Symbol, empty.Symbol);
                                playerX += 1;
                                world.array[playerX, playerY].Add(player);
                                world.array[playerX, playerY].CreateTile(
                                    player.Symbol, empty.Symbol, empty.Symbol,
                                    empty.Symbol, empty.Symbol);
                                choosing = false;
                                moved = "SOUTH";
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 'a':
                            if (playerY > 0)
                            {
                                world.array[playerX, playerY].Remove(player);
                                world.array[playerX, playerY].CreateTile(
                                    empty.Symbol, empty.Symbol, empty.Symbol,
                                    empty.Symbol, empty.Symbol);
                                playerY -= 1;
                                world.array[playerX, playerY].Add(player);
                                world.array[playerX, playerY].CreateTile(
                                    player.Symbol, empty.Symbol, empty.Symbol,
                                    empty.Symbol, empty.Symbol);
                                choosing = false;
                                moved = "WEST";
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 'd':
                            if (playerY < 7)
                            {
                                world.array[playerX, playerY].Remove(player);
                                world.array[playerX, playerY].CreateTile(
                                    empty.Symbol, empty.Symbol, empty.Symbol,
                                    empty.Symbol, empty.Symbol);
                                playerY += 1;
                                world.array[playerX, playerY].Add(player);
                                world.array[playerX, playerY].CreateTile(
                                    player.Symbol, empty.Symbol, empty.Symbol,
                                    empty.Symbol, empty.Symbol);
                                choosing = false;
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