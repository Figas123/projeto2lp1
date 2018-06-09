using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    
    class Board
    {
        private State[,] state;
        Renderer renderer = new Renderer();

        public Board()
        {
            state = new State[8, 8];
        }

        public State GetState(Position position)
        {
            return state[position.Row, position.Column];
        }
    }
}
