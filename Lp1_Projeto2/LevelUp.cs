using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class LevelUp
    {
        public bool CheckLevelUp(GameCons cons, World world)
        {
            if (world.array[world.playerX, world.playerY].Contains(cons.player) &&
                world.array[world.playerX, world.playerY].Contains(cons.exit) && cons.player.Hp != 0)
            {
                cons.level++;
                Console.Clear();
                Console.WriteLine($"\nYou've made it to level {cons.level}!" +
                    $"\nPress any Key to continue.");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
            return false;
        }
    }
}
