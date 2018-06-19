using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Interface for everything that is a weapon
    /// </summary>
    public interface IWeapon : IGameObject, IItem
    {
        /// <summary>
        /// The weapons AP
        /// </summary>
        float AP { get; set; }
        /// <summary>
        /// The weapons Durability
        /// </summary>
        float Durability { get; set; }
        /// <summary>
        /// Method to equip the weapon
        /// </summary>
        /// <param name="cons">The global constants</param>
        /// <param name="world">The current world</param>
        void Equip(GameCons cons, World world);
    }
}
