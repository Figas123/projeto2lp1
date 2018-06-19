using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class that checks the users inputs to see if they are valid
    /// </summary>
    public class Commands
    {
        /// <summary>
        /// Checks the inputs of the user
        /// </summary>
        /// <param name="cons">The global variables</param>
        /// <param name="world">The current world</param>
        public void CheckInputs(GameCons cons, World world)
        {
            // Initializing variables to make loops possible
            bool choosing = true;
            bool choosingKey = true;
            bool choosingQuit = true;
            bool choosingItem = true;
            char choiceKey = 'X';
            char choiceKeyQuit = 'X';
            char choiceKeyItem = 'X';
            // Loops while the player hasnt made a valid choice to end the turn
            while (choosing)
            {
                // Loops while the player hasnt choosen a valid key
                while (choosingKey)
                {
                    // Inicializes a string to store the users input
                    string choiceKeyStr = Console.ReadLine();
                    // Checks if the input is a valid one
                    if (choiceKeyStr.Length == 1 && (choiceKeyStr == "w" ||
                        choiceKeyStr == "s" || choiceKeyStr == "a" ||
                        choiceKeyStr == "d" || choiceKeyStr == "q" ||
                        choiceKeyStr == "f" || choiceKeyStr == "e" ||
                        choiceKeyStr == "u" || choiceKeyStr == "v" ||
                        choiceKeyStr == "i"))
                    {
                        // Transforms the user's input into a char
                        choiceKey = Convert.ToChar(choiceKeyStr);
                        break;
                    }
                    // If the user fails to choose a valid input this will show
                    Console.WriteLine("Wrong Inupt, try again...");
                }
                // Switch for all the valid inputs
                switch (choiceKey)
                {
                    // In case the input is 'w'
                    case 'w':
                        // Limits the player so he cant get off the matrix
                        if (world.playerX > 0)
                        {
                            // Removes the player from the current position
                            world.array[world.playerX, world.playerY].Remove(cons.player);
                            // Adjust to the new position
                            world.playerX -= 1;
                            // Adds the player to the new desired list
                            world.array[world.playerX, world.playerY].Add(cons.player);
                            // Adjusts the bool so we can end the loop
                            choosing = false;
                            /* Adjusts the "moved" string so we can show it
                             * later where the player moved in the messages */
                            world.moved = "NORTH";
                        }
                        /* In case the players desired position is outside
                         * the matrix this will show */
                        Console.WriteLine("Can't Move on that direction!");
                        break;
                    // In case the input is 's'
                    case 's':
                        // Limits the player so he cant get off the matrix
                        if (world.playerX < 7)
                        {
                            // Removes the player from the current list
                            world.array[world.playerX, world.playerY].Remove(cons.player);
                            // Adjust to the new position
                            world.playerX += 1;
                            // Adds the player to the new desired list
                            world.array[world.playerX, world.playerY].Add(cons.player);
                            // Adjusts the bool so we can end the loop
                            choosing = false;
                            /* Adjusts the "moved" string so we can show it
                             * later where the player moved in the messages */
                            world.moved = "SOUTH";
                        }
                        /* In case the players desired position is outside
                         * the matrix this will show */
                        Console.WriteLine("Can't Move on that direction!");
                        break;
                    // In case the input is 'a'
                    case 'a':
                        // Limits the player so he cant get off the matrix
                        if (world.playerY > 0)
                        {
                            // Removes the player from the current position
                            world.array[world.playerX, world.playerY].Remove(cons.player);
                            // Adjust to the new position
                            world.playerY -= 1;
                            // Adds the player to the new desired list
                            world.array[world.playerX, world.playerY].Add(cons.player);
                            // Adjusts the bool so we can end the loop
                            choosing = false;
                            /* Adjusts the "moved" string so we can show it
                             * later where the player moved in the messages */
                            world.moved = "WEST";
                        }
                        /* In case the players desired position is outside
                         * the matrix this will show */
                        Console.WriteLine("Can't Move on that direction!");
                        break;
                    // In case the input is 'd'
                    case 'd':
                        // Limits the player so he cant get off the matrix
                        if (world.playerY < 7)
                        {
                            // Removes the player from the current position
                            world.array[world.playerX, world.playerY].Remove(cons.player);
                            // Adjust to the new position
                            world.playerY += 1;
                            // Adds the player to the new desired list
                            world.array[world.playerX, world.playerY].Add(cons.player);
                            // Adjusts the bool so we can end the loop
                            choosing = false;
                            /* Adjusts the "moved" string so we can show it
                             * later where the player moved in the messages */
                            world.moved = "EAST";
                        }
                        /* In case the players desired position is outside
                         * the matrix this will show */
                        Console.WriteLine("Can't Move on that direction!");
                        break;
                    // In case the input is 'q'
                    case 'q':
                        // Displays a informative message to the user
                        Console.WriteLine("Are you sure you want to quit? (y/n)");
                        // Loops while the player doesnt give a valid input
                        while (choosingQuit)
                        {
                            // Inicializes a string to store the users input
                            string choiceKeyQuitStr = Console.ReadLine();
                            // Checks if the input is a valid one
                            if (choiceKeyQuitStr.Length == 1 && (choiceKeyQuitStr == "y" ||
                                choiceKeyQuitStr == "n"))
                            {
                                // Transforms the user's input into a char
                                choiceKeyQuit = Convert.ToChar(choiceKeyQuitStr);
                                break;
                            }
                            // If the user fails to choose a valid input this will show
                            Console.WriteLine("Wrong Inupt, try again...");
                        }
                        // Switch for all the valid inputs
                        switch (choiceKeyQuit)
                        {
                            // In case the input is 'y'
                            case 'y':
                                // Ends the program
                                Environment.Exit(0);
                                break;
                            // In case the input is 'n'
                            case 'n':
                                break;
                        }
                        break;
                    // In case the input is 'e'
                    case 'e':
                        /* If theres a map or food inside the player's current
                         * position it will go inside this if */
                        if (world.array[world.playerX, world.playerY].Contains(cons.map) ||
                            world.array[world.playerX, world.playerY].Contains(cons.food))
                        {
                            // Cleans the Console
                            Console.Clear();
                            // Displays a informative message to the user
                            Console.WriteLine("Select an item to Pick Up.\n -----------");
                            Console.WriteLine("0 - Go Back.");
                            /* Initializes a counter to count how many pickable
                             * things are inside the list */
                            int counter = 1;
                            /* Gos throw every object with the intergace IGameObject
                             * thats inside the players current list */
                            foreach (IGameObject thing in world.array[world.playerX, world.playerY])
                            {
                                /* Limits the things to just objects with the
                                 * interface IItem */
                                if (thing is IItem item)
                                {
                                    // Displays the propriety "Name" from the thing
                                    Console.WriteLine($"{counter} - {item.Name}.");
                                    // Increments the counter
                                    counter++;
                                }
                            }
                            // Loops while the player hasnt choosen a valid key
                            while (choosingItem)
                            {
                                // Inicializes a string to store the users input
                                string choiceKeyItemStr = Console.ReadLine();
                                /* Initializes a int to store the converted
                                 * string with the users choice */
                                int choiceKeyItemInt = Convert.ToInt32(choiceKeyItemStr);
                                /* Limits the choices of the user according to
                                 * how many things are inside the list */
                                if (choiceKeyItemStr.Length == 1 && choiceKeyItemInt <=
                                   (world.array[world.playerX, world.playerY].Count() - 1))
                                {
                                    // Transforms the user's input into a char
                                    choiceKeyItem = Convert.ToChar(choiceKeyItemStr);
                                    // Adjusts the bool so we can end the loop
                                    choosingItem = false;
                                    break;
                                }
                                // If the user fails to choose a valid input this will show
                                Console.WriteLine("Wrong Inupt, try again...");
                            }
                            /* Gos throw every object with the intergace IGameObject
                             * thats inside the current list of the player */
                            foreach (IGameObject thing in world.array[world.playerX, world.playerY])
                            {
                                /* Limits the things to just objects with the
                                 * interface IItem */
                                if (thing is IItem item)
                                {
                                    // Switch for all the valid inputs
                                    switch (choiceKeyItem)
                                    {
                                        // In case the input is '0'
                                        case '0':
                                            // Adjusts the bool so we can end the loop
                                            choosing = false;
                                            break;
                                        // In case the input is '1'
                                        case '1':
                                            /* If theres at least two thing
                                             * inside the current array */
                                            if (world.array[world.playerX, world.playerY].Count > 1)
                                            {
                                                /* Runs the PickUp() method
                                                 * from the selected item */
                                                item.PickUp(cons, world);
                                                // Adjusts the bool so we can end the loop
                                                choosing = false;
                                                break;
                                            }
                                            /* If the user fails to choose a
                                             * valid input this will show */
                                            Console.WriteLine("Select a valid option.");
                                            continue;
                                        // In case the input is '2'
                                        case '2':
                                            /* If theres at least three thing
                                             * inside the current array */
                                            if (world.array[world.playerX, world.playerY].Count > 2)
                                            {
                                                /* Runs the PickUp() method
                                                 * from the selected item */
                                                item.PickUp(cons, world);
                                                // Adjusts the bool so we can end the loop
                                                choosing = false;
                                                break;
                                            }
                                            /* If the user fails to choose a
                                             * valid input this will show */
                                            Console.WriteLine("Select a valid option.");
                                            continue;
                                        // In case the input is '3'
                                        case '3':
                                            /* If theres at least four thing
                                             * inside the current array */
                                            if (world.array[world.playerX, world.playerY].Count > 3)
                                            {
                                                /* Runs the PickUp() method
                                                 * from the selected item */
                                                item.PickUp(cons, world);
                                                // Adjusts the bool so we can end the loop
                                                choosing = false;
                                                break;
                                            }
                                            /* If the user fails to choose a
                                             * valid input this will show */
                                            Console.WriteLine("Select a valid option.");
                                            continue;
                                        default:
                                            /* If the user fails to choose a
                                             * valid input this will show */
                                            Console.WriteLine("Select a valid option.");
                                            continue;
                                    }
                                }
                            }
                        }
                        /* If theres nothing besides the player inside the 
                         * current list go in this else */
                        else
                        {
                            /* Displays a default message because theres nothing
                             * to pick up */
                            Console.WriteLine("You picked up a rock... It doesnt" +
                                " seem very useful so you decide to drop it.");
                        }
                        break;
                    // In case the input is 'f'
                    case 'f':
                        // Displays a informative message to the user
                        Console.WriteLine("You decide to frantically swing your " +
                            "spoon... Fortunatly you didnt die! It looks like " +
                            "this feature is not implemented...");
                        Console.WriteLine("Choose something else...");
                        break;
                    // In case the input is 'u'
                    case 'u':
                        // Displays a informative message to the user
                        Console.WriteLine("You decide to use your mind and think!" +
                            " Its not going so well... You figured that this " +
                            "feature is not implemented...");
                        Console.WriteLine("Choose something else...");
                        break;
                    // In case the input is 'v'
                    case 'v':
                        // Displays a informative message to the user
                        Console.WriteLine("It looks like you dropped your spoon... " +
                            "You instantly regret your decision and pick it " +
                            "back up since this feature is not implemented...");
                        Console.WriteLine("Choose something else...");
                        break;
                    // In case the input is 'i'
                    case 'i':
                        // Displays a informative message to the user
                        Console.WriteLine("We regret to informe you that " +
                            "this feature is not yet implemented...");
                        Console.WriteLine("Choose something else...");
                        break;
                }
            }
        }
    }
}