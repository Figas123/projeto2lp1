﻿using System;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to show that the user has died
    /// </summary>
    public class Dead
    {
        /// <summary>
        /// Displays a message upon death
        /// </summary>
        /// <param name="cons">The global variables</param>
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
