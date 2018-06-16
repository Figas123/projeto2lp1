using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Menu
    {
        public static bool chosing = true;

        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Program program = new Program();

            while (chosing)
            {
                Console.WriteLine("\n1. New game\n2. High scores\n3. Credits\n4. Quit");
                ConsoleKeyInfo choice = Console.ReadKey();
                if (char.IsDigit(choice.KeyChar))
                {
                    switch (choice.Key)
                    {
                        case ConsoleKey.D1:
                            program.NewGame();
                            Console.Clear();
                            chosing = false;
                            break;
                        case ConsoleKey.D2:
                            HighScores();
                            Console.Clear();
                            break;
                        case ConsoleKey.D3:
                            Credits();
                            Console.Clear();
                            break;
                        case ConsoleKey.D4:
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                    }
                }
                else Console.Clear();
            }
        }

        public static void Credits()
        {
            Console.Clear();
            Console.WriteLine("\nMade by:\n\tNuno Figueiredo - 21705451\n\t" +
                "Tomás Nogueiro 21703305");
            Console.WriteLine("\nPress any key to go back to the Main Menu.");
            Console.ReadKey();
        }

        public static void HighScores()
        {
            Console.Clear();
            Console.WriteLine("\nThis option is not implemented...");
            Console.WriteLine("\nPress any key to go back to the Main Menu.");
            Console.ReadKey();
        }
    }
}
