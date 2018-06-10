﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class Player : IExist
    {
        public int X { get; set; }
        public int Y { get; set; }
        public float Hp { get; set; }
        public string Symbol { get; set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
            Hp = 100;
            Symbol = "⨀";
        }
    }
}