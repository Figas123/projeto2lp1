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
            //Tile Tile = new Tile(0, 0, State.Unknown);

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    tiles[row, column] = RenderTile(board.GetState(new Position(row, column)));
                    //Tile = new Tile(row, column, State.Unknown);
                }
            }
            for (int row = 0; row < 8; row++)
            {
                //Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{tiles[row, 0]} - {tiles[row, 1]} - {tiles[row, 2]} " +
                $"- {tiles[row, 3]} - {tiles[row, 4]} - {tiles[row, 5]} - {tiles[row, 6]} - {tiles[row, 7]}");
                if (row < 7)
                {
                    Console.WriteLine("  |       |       |       |       |       |       |       |");
                }
            }
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