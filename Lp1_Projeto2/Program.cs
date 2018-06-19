using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class that starts the actual game
    /// </summary>
    public class Program
    {
        // Initializing required stuff
        World world = new World();
        Renderer renderer = new Renderer();
        Messages messages = new Messages();
        CheckAround check = new CheckAround();
        Inputs inputs = new Inputs();
        Commands commands = new Commands();
        LevelUp checkLevelUp = new LevelUp();
        Dead dead = new Dead();
        /// <summary>
        /// Starts the game
        /// </summary>
        /// <param name="cons">The global constants</param>
        public void NewGame(GameCons cons)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Clears the console
            Console.Clear();
            // Creates a new World
            world.CreateWorld(cons);
            // Loops while the Player's alive
            while (cons.player.Hp > 0)
            {
                // Renders the World
                renderer.Render(cons, world);
                // Renders the messages
                messages.ShowMessages(cons, world);
                // Renders what's around the Player
                check.Check(cons, world);
                // Renders the valid inputs
                inputs.WhatInputs();
                // Checks the input from the player
                commands.CheckInputs(cons, world);
                // Decrements the players HP
                cons.player.Hp--;
                // Clears the console
                Console.Clear();
                // When the player is able to level up
                if (checkLevelUp.CheckLevelUp(cons, world) == true)
                {
                    // Inititialize a new World
                    world = new World();
                    // Create a new World
                    world.CreateWorld(cons);
                    // Render the new World
                    renderer.Render(cons, world);
                }
            }
            // Displays the death message
            dead.YourDead(cons);
        }
    }
}
