using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to create the NPCs
    /// </summary>
    public class NPC : INPC
    {
        /// <summary>
        /// Defines if the NPC is hostile or neutral
        /// </summary>
        public bool Hostile { get; set; }
        /// <summary>
        /// The NPCs HP
        /// </summary>
        public float HP { get; set; }
        /// <summary>
        /// The NPCs AP
        /// </summary>
        public float AP { get; set; }
        /// <summary>
        /// The NPCs Symbol
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// The NPCs Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The NPCs constructor
        /// </summary>
        /// <param name="Hostile">Defines if the NPC is hostile or neutral</param>
        public NPC(bool Hostile)
        {
            this.Hostile = Hostile;
            HP = 20;
            AP = 3;
            if (Hostile)
            {
                Symbol = "☠";
                Name = "Hostile NPC";
            }
            else
            {
                Symbol = "☮";
                Name = "Neutral NPC";
            }
        }
        /// <summary>
        /// The NPCs ToString()
        /// </summary>
        /// <returns>Returns what's shown on the grid</returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}
