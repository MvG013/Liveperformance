using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.Klassen
{
    public abstract class Boot
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public string Type { get; set; }
        public string Beschrijving { get; set; }
        public bool Verhuurd { get; set; }

        public Boot(int id , string naam , decimal prijs , string type , string beschrijving , bool verhuurd)
        {

        }

        public Boot(int id, string naam, decimal prijs, string type, string beschrijving, bool verhuurd , int tankinhoud , int actieradius)
        {

        }
    }
}
