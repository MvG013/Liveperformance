using Liveperformance.Klassen;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.DatabaseKlassen
{
   public  class DBKlant : Database
    {
        public void ToevoegenKlant(string klantnaam , string klantemail)
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

                    CommandText = "INSERT INTO KLANT (NAAM,EMAIL) VALUES(:klantnaam , :klantemail)"
                };
                cmd.Parameters.Add("klantnaam", klantnaam);
                cmd.Parameters.Add("klantemail", klantemail);

                cmd.ExecuteNonQuery();
            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
        }
        }
    }
}
