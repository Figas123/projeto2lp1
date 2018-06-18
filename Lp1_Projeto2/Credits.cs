using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public class Credits
    {
        public void ShowCredits()
        {
            Console.Clear();
            Console.WriteLine("\nMade by:\n\tNuno Figueiredo - 21705451\n\t" +
                "Tomás Nogueiro 21703305");
            Console.WriteLine("\nPress any key to go back to the Main Menu.");
            Console.ReadKey();
        }
    }
}
