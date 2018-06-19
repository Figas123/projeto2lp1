using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to create the Food
    /// </summary>
    public class Food : IGameObject
    {
        /// <summary>
        /// The Foods Symbol
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// The Foods Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Foods constructor
        /// </summary>
        public Food()
        {
            Symbol = "✚";
            Name = "Food";
        }
        /// <summary>
        /// The Food's ToString
        /// </summary>
        /// <returns>Returns what's shown on the grid</returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}
