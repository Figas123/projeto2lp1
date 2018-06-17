using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Messages
    {
        public void ShowMessages(GameCons cons, World world)
        {
            Console.WriteLine("\n Messages:\n -----------");
            if (world.moved != "NOPE")
            {
                Console.WriteLine($"\n  * You moved {world.moved}.");
            }
            Console.WriteLine("\n -----------");
        }
    }
}
