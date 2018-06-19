using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class Tile : List<IGameObject>
    {
        public bool isVisable { get; set; }

        public Tile() : base()
        {
            isVisable = false;
        }
    }
}
