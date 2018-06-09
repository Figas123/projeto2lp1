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
            Board board = new Board();
            Renderer renderer = new Renderer();
            Program program = new Program();

            while (chosing)
            {
                Console.WriteLine("1. New game\n2. High scores\n3. Credits\n4. Quit");
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
                            //HighScores();
                            Console.Clear();
                            chosing = false;
                            break;
                        case ConsoleKey.D3:
                            //Credits();
                            Console.Clear();
                            chosing = false;
                            break;
                        case ConsoleKey.D4:
                            Console.Clear();
                            chosing = false;
                            break;
                    }
                }
                else Console.Clear();
            }
        }
    }
}
