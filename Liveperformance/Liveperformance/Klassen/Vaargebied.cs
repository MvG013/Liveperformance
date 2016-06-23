using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.Klassen
{
    public class Vaargebied
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public bool Motor { get; set; }
        public bool Spierkracht { get; set; }
        public decimal Prijs { get; set; }

        public Vaargebied (int id , string naam , bool motor , bool spierkracht,decimal prijs)
        {
            ID = id;
            Naam = naam;
            Motor = motor;
            Spierkracht = spierkracht;
            Prijs = prijs;
        }
        public override string ToString()
        {
            return ID.ToString() + " " + Naam;
        }
    }
}
