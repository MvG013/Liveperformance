using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.Klassen
{
    public class Medewerker
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public int Telefoonnummer { get; set; }
        public string Email { get; set; }

        public Medewerker(int id , string naam , int telefoonnummer , string email)
        {
            ID = id;
            Naam = naam;
            Telefoonnummer = telefoonnummer;
            Email = email;
        }
        public override string ToString()
        {
            return ID.ToString() + " " + Naam;
        }
    }
}
