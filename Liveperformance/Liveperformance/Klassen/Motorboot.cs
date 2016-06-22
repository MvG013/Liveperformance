using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.Klassen
{
    public class Motorboot : Boot
    {
        int Tankinhoud { get; set; }
        int Actieradius { get; set; }

        public Motorboot(int id , string name , decimal price, string type, string beschrijving , bool verhuurd,int tankinhoud , int actieradius) 
            :base(id,name, price, type , beschrijving ,verhuurd,tankinhoud,actieradius)
        {

        }
    }
}
