using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class GameCons
    {
        public Player player = new Player();
        public Exit exit = new Exit();
        public Map map = new Map();
        public Trap trap = new Trap();
        public Food food = new Food();
        public NPC npc = new NPC();

        public int level = 1;

        public void Cons()
        {
        }
    }
}
