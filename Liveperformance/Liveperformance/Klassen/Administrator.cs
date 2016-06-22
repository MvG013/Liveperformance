using Liveperformance.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance
{
    class Administrator
    {
        string Gebruikersnaam { get; set; }
        string Wachtwoord { get; set; }

        public Administrator(string gebruikersnaam,string wachtwoord)
        {
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
        }

        public void ToevoegenBoot(Boot boot)
        {

        }

        public void WijzigenBoot(Boot boot)
        {

        }

        public void DeleteBoot(Boot boot)
        {

        }

        public void ToevoegenArtikel(Artikel artikel)
        {

        }

        public void WijzigArtikel(Artikel artikel)
        { 

        }

        public void DeleteArtikel(Artikel artikel)
        {

        }
    }
}
