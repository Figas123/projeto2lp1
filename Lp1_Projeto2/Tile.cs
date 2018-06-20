using System.Collections.Generic;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to create a Tile
    /// </summary>
    public class Tile : List<IGameObject>
    {
        /// <summary>
        /// Defines if the Tile is visable to the player
        /// </summary>
        public bool IsVisable { get; set; }
        /// <summary>
        /// The Tiles constructor
        /// </summary>
        public Tile() : base()
        {
            IsVisable = false;
        }
    }
}
