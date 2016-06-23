using Liveperformance.Klassen;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.DatabaseKlassen
{
    public class DBSoort : Database
    {
        public string GetSoortByID(int ID)
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                { 
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                OracleCommand cmd = new OracleCommand
                {
                    Connection = conn,
                    BindByName = true,
                    CommandText =
                        "SELECT SOORT FROM SOORT WHERE SOORTID = :ID"
                };
                cmd.Parameters.Add("ID", ID);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string soort = (dr.GetString(0));
                    return soort;
                }

                return null;
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
