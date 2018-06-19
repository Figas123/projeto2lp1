using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to display the credits
    /// </summary>
    public class Credits
    {
        /// <summary>
        /// Displays the credits
        /// </summary>
        public void ShowCredits()
        {
            // Clears the console
            Console.Clear();
            // Displays a message with some cool people
            Console.WriteLine("\nMade by:\n\t21705451 - Nuno Figueiredo\n\t" +
                "21703305 - Tomás Nogueiro");
            Console.WriteLine("\nPress any key to go back to the Main Menu.");
            Console.ReadKey();
        }
    }
}
