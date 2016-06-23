using Liveperformance.Klassen;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.DatabaseKlassen
{
    public class DBVaargebied : Database
    {
        public List<Vaargebied> AlleVaarGebieden()
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                {
                    if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                List<Vaargebied> Gebieden = new List<Vaargebied>();

                OracleCommand cmd = new OracleCommand
                {
                    Connection = conn,
                    BindByName = true,
                    CommandText =
                        "SELECT * FROM VAARGEBIED"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = (dr.GetInt32(0));
                    string naam = (dr.GetString(1));
                    bool motor = Convert.ToBoolean((dr.GetString(2)));
                    bool spierkracht = Convert.ToBoolean((dr.GetString(3)));
                    decimal prijs = (dr.GetDecimal(4));

                    Vaargebied ToAdd = new Vaargebied(id,naam,motor,spierkracht,prijs);
                    Gebieden.Add(ToAdd);
                }
                return Gebieden;
            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                    return null;
            }
        }
        }

        public void ToevoegenVaargebied(string naam, string motor, string spierkracht, decimal prijs)
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
                    CommandText = "INSERT INTO VAARGEBIED(NAAM,MOTOR,SPIERKRACHT,PRIJS) VALUES(:naam,:motor,:spierkracht,:prijs)"
                };
                cmd.Parameters.Add("naam", naam);
                cmd.Parameters.Add("motor", motor);
                cmd.Parameters.Add("spierkracht", spierkracht);
                cmd.Parameters.Add("prijs", prijs);
                cmd.ExecuteNonQuery();
            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
        }
        }

        public int GetGebiedIDByNaam(string naam)
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
                        "SELECT GEBIEDID FROM VAARGEBIED WHERE NAAM = :naam"
                };
                cmd.Parameters.Add("naam", naam);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int ID = (dr.GetInt32(0));
                    return ID;
                }

                return 0;

            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                return 0;
            }
        }
        }
    }
}
