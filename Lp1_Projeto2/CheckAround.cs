using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    class CheckAround
    {
        public void Check(GameCons cons, World world)
        {
            Console.WriteLine("\n What do I see?\n -----------\n");
            // Get List of Items at North
            Console.Write($"  * NORTH : ");
            if (world.playerX > 0)
            {
                if (world.array[world.playerX - 1, world.playerY].Count() > 0)
                {
                    foreach (GameObject thing in world.array[world.playerX - 1, world.playerY])
                    {
                        if (thing != cons.player)
                        {
                            Console.Write($" {thing.Name}");
                        }
                    }
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(" Empty.\n");
                }
            }
            else
            {
                Console.WriteLine(" Wall.");
            }
            // Get List of Items at West
            Console.Write($"  * WEST  : ");
            if (world.playerY > 0)
            {
                if (world.array[world.playerX, world.playerY - 1].Count() > 0)
                {
                    foreach (GameObject thing in world.array[world.playerX, world.playerY - 1])
                    {
                        if (thing != cons.player)
                        {
                            Console.Write($" {thing.Name}");
                        }
                    }
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(" Empty.\n");
                }
            }
            else
            {
                Console.WriteLine(" Wall.");
            }
            // Get List of Items at East
            Console.Write($"  * EAST  : ");
            if (world.playerY < 7)
            {
                if (world.array[world.playerX, world.playerY + 1].Count() > 0)
                {
                    foreach (GameObject thing in world.array[world.playerX, world.playerY + 1])
                    {
                        if (thing != cons.player)
                        {
                            Console.Write($" {thing.Name}");
                        }
                    }
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(" Empty.\n");
                }
            }
            else
            {
                Console.WriteLine(" Wall.");
            }
            // Get List of Items at South
            Console.Write($"  * SOUTH : ");
            if (world.playerX < 7)
            {
                if (world.array[world.playerX + 1, world.playerY].Count() > 0)
                {
                    foreach (GameObject thing in world.array[world.playerX + 1, world.playerY])
                    {
                        if (thing != cons.player)
                        {
                            Console.Write($" {thing.Name}");
                        }
                    }
                    Console.WriteLine(".");
                }
                else
                {
                    Console.Write(" Empty.\n");
                }
            }
            else
            {
                Console.WriteLine(" Wall.");
            }
            // Get List of Items at current position
            Console.Write($"  * HERE  : ");
            if (world.array[world.playerX, world.playerY].Count() > 0)
            {
                foreach (GameObject thing in world.array[world.playerX, world.playerY])
                {
                    if (thing != cons.player)
                        if (thing != cons.player)
                        {
                            Console.Write($" {thing.Name}");
                        }
                }
                Console.WriteLine(" Empty.");
            }
            Console.WriteLine("\n -----------");
        }
    }
}
