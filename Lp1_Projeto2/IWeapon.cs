using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    public interface IWeapon
    {
        float AP { get; set; }
        float Durability { get; set; }
        string Name { get; set; }

        void PickUp();
        void Equip();
    }
}
