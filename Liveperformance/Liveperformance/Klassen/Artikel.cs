using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.Klassen
{
    public class Artikel
    {
        public int ArtikelID { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public string Beschrijving { get; set; }
        public bool Verhuurd { get; set; }

        public Artikel(int artikelid , string naam , decimal prijs, string beschrijving , bool verhuurd)
        {
            ArtikelID = artikelid;
            Naam = naam;
            Prijs = prijs;
            Beschrijving = beschrijving;
            Verhuurd = verhuurd;
        }
    }
}
