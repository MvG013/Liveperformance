﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.Klassen
{
    public class Kano : Boot
    {
        public Kano(int id, string name, decimal price, string type, string beschrijving, bool verhuurd) 
            :base(id,name, price, type , beschrijving ,verhuurd)
        {

        }
    }
}