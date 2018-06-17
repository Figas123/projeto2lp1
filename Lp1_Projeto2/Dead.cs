using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Dead
    {
        public void YourDead(GameCons cons)
        {
            Console.Clear();
            Console.WriteLine($"\nYou've died, what a shame...\n" +
                $"You made it till level {cons.level}!");
            Console.ReadLine();
            Environment.Exit(0);
            Console.ReadKey();
        }
    }
}
