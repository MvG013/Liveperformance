using Microsoft.VisualStudio.TestTools.UnitTesting;
using Liveperformance.DatabaseKlassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.DatabaseKlassen.Tests
{
    [TestClass()]
    public class DBSoortTests
    {
        [TestMethod()]
        public void GetSoortByIDTest()
        {
            DBSoort dbsoort = new DBSoort();
            string soort = dbsoort.GetSoortByID(1);
            Equals(soort = "Kano");
        }
    }
}