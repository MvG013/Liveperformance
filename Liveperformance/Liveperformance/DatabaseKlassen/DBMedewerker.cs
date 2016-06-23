using Liveperformance.Klassen;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.DatabaseKlassen
{
    public class DBMedewerker : Database
    {
        public List<Medewerker> AlleMedewerkers()
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                List<Medewerker> Medewerkers = new List<Medewerker>();

                OracleCommand cmd = new OracleCommand
                {
                    Connection = conn,
                    BindByName = true,
                    CommandText =
                        "SELECT * FROM MEDEWERKER"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = (dr.GetInt32(0));
                    string naam = (dr.GetString(1));
                    int telefoonnummer = (dr.GetInt32(2));
                    string email = (dr.GetString(3));

                    Medewerker ToAdd = new Medewerker(id,naam,telefoonnummer,email);
                    Medewerkers.Add(ToAdd);
                }
                return Medewerkers;
            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                return null;
            }
        }
        }

        public string GetMedewerkerNaamByID(int ID)
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
                        "SELECT NAAM FROM MEDEWERKER WHERE MEDEWERKERID = :ID"
                };
                cmd.Parameters.Add("ID", ID);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string Naam = (dr.GetString(0));
                    return Naam;
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

        public int GetMedewerkerIDbyNaam(string naam)
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
                        "SELECT MEDEWERKERID FROM MEDEWERKER WHERE NAAM = :naam"
                };
                cmd.Parameters.Add("naam", naam);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int ID = (dr.GetInt32(0));
                    return ID;
                }
                }
                catch (OracleException e)
                {
                    Console.WriteLine("Message: " + e.Message);
                    return 0;
                }
            }

            return 0;

            }
        public Medewerker GetMedewerkerByID(int ID)
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
                            "SELECT * FROM MEDEWERKER WHERE MEDEWERKERID = :ID"
                    };
                    cmd.Parameters.Add("ID", ID);

                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        int id = (dr.GetInt32(0));
                        string naam = (dr.GetString(1));
                        int telefoonnummer = (dr.GetInt32(2));
                        string email = (dr.GetString(3));
                        Medewerker medewerker = new Medewerker(id, naam, telefoonnummer, email);
                        return medewerker;
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
