namespace Lp1_Projeto2
{
    /// <summary>
    /// Class to create the Exit
    /// </summary>
    public class Exit : IGameObject
    {
        /// <summary>
        /// The Exits Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Exits constructor
        /// </summary>
        public Exit()
        {
            Name = "Exit";
        }
        /// <summary>
        /// The Exits ToString
        /// </summary>
        /// <returns>Returns what's shown on the grid</returns>
        public override string ToString()
        {
            return "E X I T ";
        }
    }
}
