using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to create the Player
    /// </summary>
    public class Player : IGameObject
    {
        /// <summary>
        /// The Players HP
        /// </summary>
        public float Hp { get; set; }
        /// <summary>
        /// The Players Symbol
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// The Players Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Players constructor
        /// </summary>
        public Player()
        {
            Hp = 100;
            Symbol = "⛨";
            Name = "Player";
        }
        /// <summary>
        /// The Players ToString()
        /// </summary>
        /// <returns>Returns what's shown on the grid</returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}
