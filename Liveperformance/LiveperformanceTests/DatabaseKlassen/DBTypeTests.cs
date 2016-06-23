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
    public class DBTypeTests
    {
        [TestMethod()]
        public void GetTypeByIDTest()
        {
            DBType dbtype = new DBType();
            string type = dbtype.GetTypeByID(1);
            Equals(type = "Valk");

        }
    }
}