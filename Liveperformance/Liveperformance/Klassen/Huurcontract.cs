using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.Klassen
{
    public class Huurcontract
    {
        public int ID { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }

        public List<Vaargebied> Vaargebieden = new List<Vaargebied>();
        public List<Boot> Boten = new List<Boot>();
        public List<Artikel> Artikelen = new List<Artikel>();
        public Klant klant { get; set; }
        public Medewerker medewerker { get; set; }

    }
}
