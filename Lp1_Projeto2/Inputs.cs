﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class Inputs
    {
        public void WhatInputs()
        {
            Console.WriteLine("\n Inputs:\n -----------");
            Console.WriteLine("\n  (w) - Move NORTH  (a) - Move WEST     " +
                "(d) - Move EAST  (s) - Move SOUTH");
            Console.WriteLine("\n  (f) - Attack NPC  (e) - Pick up item  " +
                "(u) - Use item   (v) - Drop item");
            Console.WriteLine("\n  (i) - Information (q) - Quit game");
            Console.WriteLine("\n -----------");
        }
    }
}