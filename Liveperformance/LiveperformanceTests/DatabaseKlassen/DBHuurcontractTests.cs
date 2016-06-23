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
    public class DBHuurcontractTests
    {
        //tijdnood niet veel tests kunnen maken..
        [TestMethod()]
        public void GetContractIDTest()
        {
            DBHuurcontract dbhuur = new DBHuurcontract();
            int id = dbhuur.GetContractID(1, "safae", "dafssd", Convert.ToDateTime("25-06-16"), Convert.ToDateTime("26-06-16"), Convert.ToDecimal("13,25"));
            Equals(id = 18);
        }
    }
}