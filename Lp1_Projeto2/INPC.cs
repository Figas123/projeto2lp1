using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    /// <summary>
    /// Interface for everything that's considered an NPC
    /// </summary>
    public interface INPC : IGameObject
    {
        /// <summary>
        /// The NPCs HP
        /// </summary>
        float HP { get; set; }
        /// <summary>
        /// The NPCs AP
        /// </summary>
        float AP { get; set; }
    }
}
