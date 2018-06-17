using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Menu
    {

        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Program program = new Program();
            Credits credits = new Credits();
            HighScores highScores = new HighScores();
            GameCons cons = new GameCons();

            bool chosingMenu = true;

            while (chosingMenu)
            {
                Console.WriteLine("\n1. New game\n2. High scores\n3. Credits\n4. Quit");
                ConsoleKeyInfo choice = Console.ReadKey();
                if (char.IsDigit(choice.KeyChar))
                {
                    switch (choice.Key)
                    {
                        case ConsoleKey.D1:
                            cons.Cons();
                            program.NewGame(cons);
                            Console.Clear();
                            chosingMenu = false;
                            break;
                        case ConsoleKey.D2:
                            highScores.ShowHighScores();
                            Console.Clear();
                            break;
                        case ConsoleKey.D3:
                            credits.ShowCredits();
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
    }
}
