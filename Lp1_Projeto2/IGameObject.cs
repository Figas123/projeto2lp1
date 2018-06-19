using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Interface for every object that can be placed on the world
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// The Name of the object
        /// </summary>
        string Name { get; set; }
    }
}
