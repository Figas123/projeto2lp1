using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class Commands
    {
        public void CheckInputs(GameCons cons, World world)
        {
            bool choosing = true;
            bool choosingKey = true;
            bool choosingQuit = true;
            bool choosingItem = true;
            char choiceKey = 'X';
            char choiceKeyQuit = 'X';
            char choiceKeyItem = 'X';

            while (choosing)
            {
                while (choosingKey)
                {
                    string choiceKeyStr = Console.ReadLine();
                    if (choiceKeyStr.Length == 1 && (choiceKeyStr == "w" ||
                        choiceKeyStr == "s" || choiceKeyStr == "a" ||
                        choiceKeyStr == "d" || choiceKeyStr == "q" ||
                        choiceKeyStr == "f" || choiceKeyStr == "e" ||
                        choiceKeyStr == "u" || choiceKeyStr == "v" ||
                        choiceKeyStr == "i"))
                    {
                        choiceKey = Convert.ToChar(choiceKeyStr);
                        break;
                    }
                    Console.WriteLine("Wrong Inupt, try again...");
                }
                switch (choiceKey)
                {
                    case 'w':
                        if (world.playerX > 0)
                        {
                            world.array[world.playerX, world.playerY].Remove(cons.player);
                            world.playerX -= 1;
                            world.array[world.playerX, world.playerY].Add(cons.player);
                            choosing = false;
                            world.moved = "NORTH";
                        }
                        Console.WriteLine("Can't Move on that direction!");
                        break;
                    case 's':
                        if (world.playerX < 7)
                        {
                            world.array[world.playerX, world.playerY].Remove(cons.player);
                            world.playerX += 1;
                            world.array[world.playerX, world.playerY].Add(cons.player);
                            choosing = false;
                            world.moved = "SOUTH";
                        }
                        Console.WriteLine("Can't Move on that direction!");
                        break;
                    case 'a':
                        if (world.playerY > 0)
                        {
                            world.array[world.playerX, world.playerY].Remove(cons.player);
                            world.playerY -= 1;
                            world.array[world.playerX, world.playerY].Add(cons.player);
                            choosing = false;
                            world.moved = "WEST";
                        }
                        Console.WriteLine("Can't Move on that direction!");
                        break;
                    case 'd':
                        if (world.playerY < 7)
                        {
                            world.array[world.playerX, world.playerY].Remove(cons.player);
                            world.playerY += 1;
                            world.array[world.playerX, world.playerY].Add(cons.player);
                            choosing = false;
                            world.moved = "EAST";
                        }
                        Console.WriteLine("Can't Move on that direction!");
                        break;
                    case 'q':
                        Console.WriteLine("Are you sure you want to quit? (y/n)");
                        while (choosingQuit)
                        {
                            string choiceKeyQuitStr = Console.ReadLine();
                            if (choiceKeyQuitStr.Length == 1 && (choiceKeyQuitStr == "y" ||
                                choiceKeyQuitStr == "n"))
                            {
                                choiceKeyQuit = Convert.ToChar(choiceKeyQuitStr);
                                break;
                            }
                            Console.WriteLine("Wrong Inupt, try again...");
                        }
                        switch (choiceKeyQuit)
                        {
                            case 'y':
                                Environment.Exit(0);
                                break;
                            case 'n':
                                break;
                        }
                        break;
                    case 'e':
                        if (world.array[world.playerX, world.playerY].Contains(cons.map) ||
                            world.array[world.playerX, world.playerY].Contains(cons.food))
                        {
                            Console.Clear();
                            Console.WriteLine("Select an item to Pick Up.\n -----------");
                            Console.WriteLine("0 - Go Back.");
                            int counter = 1;
                            foreach (IGameObject thing in world.array[world.playerX, world.playerY])
                            {
                                IItem item = thing as IItem;

                                if (item != null)
                                {
                                    Console.WriteLine($"{counter} - {thing.Name}.");
                                    counter++;
                                }
                            }
                            while (choosingItem)
                            {
                                string choiceKeyItemStr = Console.ReadLine();
                                int limit = 0;
                                for (int i = 0; i < world.array[world.playerX, world.playerY].Count(); i++)
                                {
                                    limit++;
                                }
                                int choiceKeyItemInt = Convert.ToInt32(choiceKeyItemStr);
                                if (choiceKeyItemStr.Length == 1 && choiceKeyItemInt <= limit)
                                {
                                    choiceKeyItem = Convert.ToChar(choiceKeyItemStr);
                                    choosingItem = false;
                                    break;
                                }
                                Console.WriteLine("Wrong Inupt, try again...");
                            }
                            foreach (IGameObject thing in world.array[world.playerX, world.playerY])
                            {
                                IItem item = thing as IItem;

                                if (item != null)
                                {
                                    switch (choiceKeyItem)
                                    {
                                        case '0':
                                            choosing = false;
                                            break;
                                        case '1':
                                            if (world.array[world.playerX, world.playerY].Count > 1)
                                            {
                                                item.PickUp(cons, world);
                                                choosing = false;
                                                break;
                                            }
                                            Console.WriteLine("Select a valid option.");
                                            continue;
                                        case '2':
                                            if (world.array[world.playerX, world.playerY].Count > 2)
                                            {
                                                item.PickUp(cons, world);
                                                choosing = false;
                                                break;
                                            }
                                            Console.WriteLine("Select a valid option.");
                                            continue;
                                        case '3':
                                            if (world.array[world.playerX, world.playerY].Count > 3)
                                            {
                                                item.PickUp(cons, world);
                                                choosing = false;
                                                break;
                                            }
                                            Console.WriteLine("Select a valid option.");
                                            continue;
                                        default:
                                            Console.WriteLine("Select a valid option.");
                                            continue;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You picked up a rock... It doesnt" +
                                " seem very useful so you decide to drop it.");
                        }
                        break;
                    case 'f':
                        Console.WriteLine("You decide to frantically swing your " +
                            "spoon... Fortunatly you didnt die! It looks like " +
                            "this feature is not implemented...");
                        Console.WriteLine("Choose something else...");
                        break;
                    case 'u':
                        Console.WriteLine("You decide to use your mind and think!" +
                            " Its not going so well... You figured that this " +
                            "feature is not implemented...");
                        Console.WriteLine("Choose something else...");
                        break;
                    case 'v':
                        Console.WriteLine("It looks like you dropped your spoon... " +
                            "You instantly regret your decision and pick it " +
                            "back up since this feature is not implemented...");
                        Console.WriteLine("Choose something else...");
                        break;
                    case 'i':
                        Console.WriteLine("We regret to informe you that " +
                            "this feature is not yet implemented...");
                        Console.WriteLine("Choose something else...");
                        break;
                }
            }
        }
    }
}