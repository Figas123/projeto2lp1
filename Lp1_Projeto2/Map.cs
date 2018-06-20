namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to create the Map
    /// </summary>
    public class Map : IItem
    {
        /// <summary>
        /// The Maps Symbol
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// The Maps Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Maps constructor
        /// </summary>
        public Map()
        {
            Symbol = "⍠";
            Name = "Map";
        }
        /// <summary>
        /// The Maps Pick Up method
        /// </summary>
        /// <param name="cons">The global constants</param>
        /// <param name="world">The current world</param>
        public void PickUp(GameCons cons, World world)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    // Makes all tiles visable
                    world.array[row, column].IsVisable = true;
                }
            }
        }
        /// <summary>
        /// The Maps ToString()
        /// </summary>
        /// <returns>Returns what's shown on the grid</returns>
        public override string ToString()
        {
            return Symbol;
        }
    }
}
