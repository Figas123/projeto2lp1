﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp1_Projeto2
{
    interface IItem : IWeight
    {
        string Name { get; set; }

        void PickUp();
        void Use();
    }
}
