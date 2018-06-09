using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Renderer
    {
        public void Render(Board board)
        {
            string[,] tiles = new string[8, 8];

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    tiles[row, column] = RenderTile(board.GetState(new Position(row, column)));
                }
            }
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{tiles[0, 0]} - {tiles[1, 0]} - {tiles[2, 0]} " +
                $"- {tiles[3, 0]} - {tiles[4, 0]} - {tiles[5, 0]} - {tiles[6, 0]} - {tiles[7, 0]}");
            Console.WriteLine("  |       |       |       |       |       |       |       |");
            Console.WriteLine($"{tiles[0, 1]} - {tiles[1, 1]} - {tiles[2, 1]} " +
                $"- {tiles[3, 1]} - {tiles[4, 1]} - {tiles[5, 1]} - {tiles[6, 1]} - {tiles[7, 1]}");
            Console.WriteLine("  |       |       |       |       |       |       |       |");
            Console.WriteLine($"{tiles[0, 2]} - {tiles[1, 2]} - {tiles[2, 2]} " +
                $"- {tiles[3, 2]} - {tiles[4, 2]} - {tiles[5, 2]} - {tiles[6, 2]} - {tiles[7, 2]}");
            Console.WriteLine("  |       |       |       |       |       |       |       |");
            Console.WriteLine($"{tiles[0, 3]} - {tiles[1, 3]} - {tiles[2, 3]} " +
                $"- {tiles[3, 3]} - {tiles[4, 3]} - {tiles[5, 3]} - {tiles[6, 3]} - {tiles[7, 3]}");
            Console.WriteLine("  |       |       |       |       |       |       |       |");
            Console.WriteLine($"{tiles[0, 4]} - {tiles[1, 4]} - {tiles[2, 4]} " +
                $"- {tiles[3, 4]} - {tiles[4, 4]} - {tiles[5, 4]} - {tiles[6, 4]} - {tiles[7, 4]}");
            Console.WriteLine("  |       |       |       |       |       |       |       |");
            Console.WriteLine($"{tiles[0, 5]} - {tiles[1, 5]} - {tiles[2, 5]} " +
                $"- {tiles[3, 5]} - {tiles[4, 5]} - {tiles[5, 5]} - {tiles[6, 5]} - {tiles[7, 5]}");
            Console.WriteLine("  |       |       |       |       |       |       |       |");
            Console.WriteLine($"{tiles[0, 6]} - {tiles[1, 6]} - {tiles[2, 6]} " +
                $"- {tiles[3, 6]} - {tiles[4, 6]} - {tiles[5, 6]} - {tiles[6, 6]} - {tiles[7, 6]}");
            Console.WriteLine("  |       |       |       |       |       |       |       |");
            Console.WriteLine($"{tiles[0, 7]} - {tiles[1, 7]} - {tiles[2, 7]} " +
                $"- {tiles[3, 7]} - {tiles[4, 7]} - {tiles[5, 7]} - {tiles[6, 7]} - {tiles[7, 7]}");
        }

        public string RenderTile(State state)
        {
            switch (state)
            {
                case State.Unknown: return "/////";
                case State.Exit: return "EXIT!";
                case State.Known: return ".....";
                default: return "?????";
            }
        }
    }
}
