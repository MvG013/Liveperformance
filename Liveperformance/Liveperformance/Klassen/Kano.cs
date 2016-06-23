using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.Klassen
{
    public class Kano : Boot
    {
        public Kano(int id, string naam, string type, string soort, decimal prijs, string beschrijving) 
            :base(id, naam, type, soort, prijs, beschrijving)
        {
            ID = id;
            Naam = naam;
            Type = type;
            Soort = soort;
            Prijs = prijs;
            Beschrijving = beschrijving;
        }

        public override string ToString()
        {
            return ID.ToString() + " " + Naam + " " + Soort;
        }
    }
}