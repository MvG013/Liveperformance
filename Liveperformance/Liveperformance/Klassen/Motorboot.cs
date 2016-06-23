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

        public Motorboot(int id , string naam, string type, string soort , decimal prijs, int tankinhoud, int actieradius , string beschrijving) 
            :base(id,naam, type, soort, prijs , beschrijving)
        {
            ID = id;
            Naam = naam;
            Type = type;
            Soort = soort;
            Prijs = prijs;
            Beschrijving = beschrijving;
            Tankinhoud = tankinhoud;
            Actieradius = actieradius;
        }

        public override string ToString()
        {
            return ID.ToString() + " " + Naam + " " + Soort;
        }
    }
}
