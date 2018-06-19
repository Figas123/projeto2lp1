using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class that creates a Trap
    /// </summary>
    public class Trap : IGameObject
    {
        /// <summary>
        /// The Traps Damage
        /// </summary>
        public float Damage { get; set; }
        /// <summary>
        /// The Traps Symbol
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// The Traps Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Traps constructor
        /// </summary>
        public Trap()
        {
            Damage = 5;
            Symbol = "☢";
            Name = "Hole";
        }
        /// <summary>
        /// The Traps ToString()
        /// </summary>
        /// <returns>Returns what's shown on the grid</returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}
