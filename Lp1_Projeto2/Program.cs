using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Program
    {
        Board board = new Board();
        Renderer renderer = new Renderer();

        public void NewGame()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            renderer.Render(board);
            Console.ReadKey();
        }
    }
}
