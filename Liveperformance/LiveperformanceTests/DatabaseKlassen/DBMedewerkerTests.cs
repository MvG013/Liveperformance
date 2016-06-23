using Microsoft.VisualStudio.TestTools.UnitTesting;
using Liveperformance.DatabaseKlassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liveperformance.Klassen;

namespace Liveperformance.DatabaseKlassen.Tests
{
    [TestClass()]
    public class DBMedewerkerTests
    {
        [TestMethod()]
        public void GetMedewerkerByIDTest()
        {
            DBMedewerker dbmedewerker = new DBMedewerker();
            Medewerker medewerker = dbmedewerker.GetMedewerkerByID(1);
            Equals(medewerker.Naam = "Henk van Laafland");
            Equals(medewerker.Email = "Henklaaf@gmail.com");
            Equals(medewerker.Telefoonnummer = 0612345678);

        }

        [TestMethod()]
        public void GetMedewerkerIDbyNaamTest()
        {
            DBMedewerker dbmedewerker = new DBMedewerker();
            int id = dbmedewerker.GetMedewerkerIDbyNaam("Rens Jager");
            Equals(id = 2);
        }

        [TestMethod()]
        public void GetMedewerkerNaamByIDTest()
        {
            DBMedewerker dbmedewerker = new DBMedewerker();
            string naam = dbmedewerker.GetMedewerkerNaamByID(3);
            Equals(naam = "Ivy van Gool");
        }


        //public void GetContractIDTest()
        //{
        //    DBHuurcontract dbhuur = new DBHuurcontract();
        //    int id = dbhuur.GetContractID(1, "safae", "dafssd", Convert.ToDateTime("25-06-16"), Convert.ToDateTime("26-06-16"), Convert.ToDecimal("13,25"));
        //    Equals(id = 18);
        //}
    }
}