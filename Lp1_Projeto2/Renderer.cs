using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Renderer
    {
        public void Render(World world)
        {
            Menu menu = new Menu();

            Random random = new Random();
            Player player = new Player();
            Empty empty = new Empty();

            bool game = true;
            int playerX = random.Next(1, 8);
            int playerY = 0;

            world.array[playerX, playerY].CreateTile(player.Symbol, empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol);
            world.array[playerX, playerY].Add(player);

            world.array[random.Next(1, 8), 7].CreateTile("E ", "X ", "I ", "T ", "! ");
            while (game)
            {
                for (int row = 0; row < 8; row++)
                {
                    for (int column = 0; column < 8; column++)
                    {
                        Console.Write($"{world.array[row, column].FirstSymbol}{world.array[row, column].SecondSymbol}" +
                            $"{world.array[row, column].ThirdSymbol}{world.array[row, column].FourthSymbol}{world.array[row, column].FifthSymbol}");
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
                        Console.WriteLine("    |            |            |            |            |            |            |            |");
                    }
                }
                Console.WriteLine("\nPlayer's HP: " + player.Hp + "\n");
                bool choosing = true;
                bool choosing2 = true;
                char choice = 'X';

                while (choosing)
                {
                    while (choosing2)
                    {
                        string choiceStr = Console.ReadLine();
                        if (choiceStr.Length == 1 && (choiceStr == "w" || choiceStr == "s" || choiceStr == "a" || choiceStr == "d"))
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
                                world.array[playerX, playerY].CreateTile(empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol);
                                playerX -= 1;
                                world.array[playerX, playerY].Add(player);
                                world.array[playerX, playerY].CreateTile(player.Symbol, empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol);
                                choosing = false;
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 's':
                            if (playerX < 7)
                            {
                                world.array[playerX, playerY].Remove(player);
                                world.array[playerX, playerY].CreateTile(empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol);
                                playerX += 1;
                                world.array[playerX, playerY].Add(player);
                                world.array[playerX, playerY].CreateTile(player.Symbol, empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol);
                                choosing = false;
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 'a':
                            if (playerY > 0)
                            {
                                world.array[playerX, playerY].Remove(player);
                                world.array[playerX, playerY].CreateTile(empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol);
                                playerY -= 1;
                                world.array[playerX, playerY].Add(player);
                                world.array[playerX, playerY].CreateTile(player.Symbol, empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol);
                                choosing = false;
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                        case 'd':
                            if (playerY < 7)
                            {
                                world.array[playerX, playerY].Remove(player);
                                world.array[playerX, playerY].CreateTile(empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol);
                                playerY += 1;
                                world.array[playerX, playerY].Add(player);
                                world.array[playerX, playerY].CreateTile(player.Symbol, empty.Symbol, empty.Symbol, empty.Symbol, empty.Symbol);
                                choosing = false;
                            }
                            Console.WriteLine("Can't Move on that direction!");
                            break;
                    }
                }
                player.Hp--;
                if (player.Hp == 0)
                {
                    game = false;
                }
                Console.Clear();
            }
            Console.WriteLine("You died, what a shame...");
            Console.ReadLine();
        }
    }
}