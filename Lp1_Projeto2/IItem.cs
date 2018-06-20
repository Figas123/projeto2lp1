namespace Lp1_Projeto2
{
    /// <summary>
    /// Interface for everything that's able to be picked up
    /// </summary>
    public interface IItem : IGameObject
    {
        /// <summary>
        /// Method to pick up the item
        /// </summary>
        /// <param name="cons">The global variables</param>
        /// <param name="world">The current world</param>
        void PickUp(GameCons cons, World world);
    }
}
