using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class Map : IGameObject, IItem
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }

        public Map()
        {
            Symbol = "⍠";
            Name = "Map";
        }

        public void PickUp(GameCons cons, World world)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    world.array[row, column].isVisable = true;
                }
            }
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
