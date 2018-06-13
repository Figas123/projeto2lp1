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
            Random random = new Random();
            bool game = true;
            
            world.tile[random.Next(1, 8), 0].CreateTile('P', '.', '.', '.', '.');
            world.tile[random.Next(1, 8), 7].CreateTile('E', 'X', 'I', 'T', '!');
            while (game)
            {
                for (int row = 0; row < 8; row++)
                {
                    for (int column = 0; column < 8; column++)
                    {
                        Console.Write($"{world.tile[row, column].FirstSymbol}{world.tile[row, column].SecondSymbol}" +
                            $"{world.tile[row, column].ThirdSymbol}{world.tile[row, column].FourthSymbol}{world.tile[row, column].FifthSymbol}");
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
                        Console.WriteLine("  |       |       |       |       |       |       |       |");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}