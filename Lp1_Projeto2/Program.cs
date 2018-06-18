using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class Program
    {
        World world = new World();
        Renderer renderer = new Renderer();
        Messages messages = new Messages();
        CheckAround check = new CheckAround();
        Inputs inputs = new Inputs();
        Commands commands = new Commands();
        LevelUp checkLevelUp = new LevelUp();
        Dead dead = new Dead();

        public void NewGame(GameCons cons)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            world.CreateWorld(cons);
            while (cons.player.Hp > 0)
            {
                renderer.Render(cons, world);
                messages.ShowMessages(cons, world);
                check.Check(cons, world);
                inputs.WhatInputs();
                commands.CheckInputs(cons, world);
                cons.player.Hp--;
                Console.Clear();
                if (checkLevelUp.CheckLevelUp(cons, world) == true)
                {
                    world = new World();
                    world.CreateWorld(cons);
                    renderer.Render(cons, world);
                }
            }
            dead.YourDead(cons);
        }
    }
}
