using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class that shows the menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// The beginning of the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Initializing required stuff
            Renderer renderer = new Renderer();
            Program program = new Program();
            Credits credits = new Credits();
            HighScores highScores = new HighScores();
            GameCons cons = new GameCons();

            bool chosingMenu = true;
            // Loops while the player hasnt made a valid choice
            while (chosingMenu)
            {
                Console.WriteLine("\n1. New game\n2. High scores\n3. Credits\n4. Quit");
                // Converts the players choice into a ConsoleKeyInfo
                ConsoleKeyInfo choice = Console.ReadKey();
                // In case the "choice" is a Digit
                if (char.IsDigit(choice.KeyChar))
                {
                    // Switch for all the valid inputs
                    switch (choice.Key)
                    {
                        // In case the input is '1'
                        case ConsoleKey.D1:
                            // Initializes the global constants
                            cons.Cons();
                            // Starts the Game
                            program.NewGame(cons);
                            // Clears the console
                            Console.Clear();
                            chosingMenu = false;
                            break;
                        // In case the input is '2'
                        case ConsoleKey.D2:
                            // Shows the HighScores
                            highScores.ShowHighScores();
                            // Clears the console
                            Console.Clear();
                            break;
                        // In case the input is '3'
                        case ConsoleKey.D3:
                            // Shows the credits
                            credits.ShowCredits();
                            // Clears the console
                            Console.Clear();
                            break;
                        // In case the input is '4'
                        case ConsoleKey.D4:
                            // Clears the console
                            Console.Clear();
                            // Ends the program
                            Environment.Exit(0);
                            break;
                    }
                }
                // Clears the console
                else Console.Clear();
            }
        }
    }
}
