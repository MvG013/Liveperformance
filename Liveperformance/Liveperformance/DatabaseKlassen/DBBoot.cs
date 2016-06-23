using Liveperformance.Klassen;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.DatabaseKlassen
{
    public class DBBoot : Database
    {
        DBSoort dbsoort = new DBSoort();
        DBType dbtype = new DBType();

        public List<Boot> AlleBoten()
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                { 
                List<Boot> Boten = new List<Boot>();

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }


                OracleCommand cmd = new OracleCommand
                {
                    Connection = conn,
                    BindByName = true,
                    CommandText =
                        "SELECT * FROM BOOT"
                };

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int id = (dr.GetInt32(0));
                    string naam = (dr.GetString(1));
                    int typeid = (dr.GetInt32(2));
                    int soortid = (dr.GetInt32(3));
                    decimal prijs = (dr.GetDecimal(4));
                    int tankinhoud = (dr.GetInt32(5));
                    int actieradius = (dr.GetInt32(6));
                    string beschrijving = (dr.GetString(7));

                    string soort = dbsoort.GetSoortByID(soortid);
                    string type = dbtype.GetTypeByID(typeid);
                    if (soort == "Motorboot")
                    {
                        actieradius = tankinhoud * 15;
                        Motorboot toAdd = new Motorboot(id, naam, type, soort, prijs, tankinhoud, actieradius, beschrijving);
                        Boten.Add(toAdd);
                    }
                    else if (soort == "Zeilboot")
                    {
                        Zeilboot toAdd = new Zeilboot(id, naam, type, soort, prijs,beschrijving);
                        Boten.Add(toAdd);
                    }
                    else if (soort == "Kano")
                    {
                        Zeilboot toAdd = new Zeilboot(id, naam, type, soort, prijs, beschrijving);
                        Boten.Add(toAdd);
                    }
                }
                return Boten;
            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                return null;
            }
        }
        }

    }
}
