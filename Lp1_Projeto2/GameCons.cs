using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to store the Game's constants
    /// </summary>
    public class GameCons
    {
        public Player player = new Player();
        public Exit exit = new Exit();
        public Map map = new Map();
        public Trap trap = new Trap();
        public Food food = new Food();
        public NPC npcH = new NPC(true);
        public NPC npcN = new NPC(false);

        public int level = 1;
        /// <summary>
        /// The GameCons constructor
        /// </summary>
        public void Cons()
        {
        }
    }
}
