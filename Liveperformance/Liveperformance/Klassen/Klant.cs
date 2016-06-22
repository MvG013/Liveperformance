using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.Klassen
{
    public class Klant
    {
        public string Naam { get; set; }
        public string Email { get; set; }

        public Klant(string naam , string email)
        {
            Naam = naam;
            Email = email;
        }
    }
}
