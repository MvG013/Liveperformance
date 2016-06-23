using Liveperformance.Klassen;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.DatabaseKlassen
{
    public class DBType : Database
    {
        public string GetTypeByID(int ID)
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
                            "SELECT TYPE FROM TYPE WHERE TYPEID = :ID"
                    };
                    cmd.Parameters.Add("ID", ID);

                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string type = (dr.GetString(0));
                        return type;
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
