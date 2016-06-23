using Liveperformance.Klassen;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.DatabaseKlassen
{
    public class DBHuurcontract : Database
    {
        DBMedewerker dbmedewerker = new DBMedewerker();
        public List<Huurcontract> AlleHuurcontracten()
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                List<Huurcontract> Contracten = new List<Huurcontract>();

                OracleCommand cmd = new OracleCommand
                {
                    Connection = conn,
                    BindByName = true,
                    CommandText =
                        "SELECT * FROM HUURCONTRACT"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = (dr.GetInt32(0));
                    int medewerkerid = (dr.GetInt32(1));
                    string klantnaam = (dr.GetString(2));
                    string klantemail = (dr.GetString(3));
                    DateTime begindatum = (dr.GetDateTime(4));
                    DateTime einddatum = (dr.GetDateTime(5));
                    decimal prijs = (dr.GetDecimal(6));

                    string medewerkernaam = dbmedewerker.GetMedewerkerNaamByID(medewerkerid);

                    Medewerker medewerker = dbmedewerker.GetMedewerkerByID(medewerkerid);
                    Klant klant = new Klant(klantnaam, klantemail);
                    Huurcontract ToAdd = new Huurcontract(id,medewerker,klant,begindatum,einddatum,prijs);
                    Contracten.Add(ToAdd);
                }
                return Contracten;
            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
                return null;
            }
        }
        }

        public void ToevoegenContract(int medewerkerid, string klantnaam, string klantemail, DateTime begindatum, DateTime einddatum , decimal prijs)
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

                CommandText = "INSERT INTO HUURCONTRACT (MEDEWERKERID,KLANTNAAM,KLANTEMAIL,BEGINDATUM,EINDDATUM,PRIJS) VALUES(:medewerkerid , :klantnaam , :klantemail , :begindatum , :einddatum ,:prijs)"
            };
            cmd.Parameters.Add("medewerkerid", medewerkerid);
            cmd.Parameters.Add("klantnaam", klantnaam);
            cmd.Parameters.Add("klantemail", klantemail);
            cmd.Parameters.Add("begindatum", begindatum);
            cmd.Parameters.Add("einddatum", einddatum);
            cmd.Parameters.Add("prijs", prijs);

                cmd.ExecuteNonQuery();
            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
        }
        }

        public int GetContractID(int medewerkerid, string klantnaam, string klantemail, DateTime begindatum, DateTime einddatum, decimal prijs)
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                List<Huurcontract> Contracten = new List<Huurcontract>();

                OracleCommand cmd = new OracleCommand
                {
                    Connection = conn,
                    BindByName = true,
                    CommandText =
                        "SELECT CONTRACTID FROM HUURCONTRACT WHERE MEDEWERKERID = :medewerkerid AND KLANTNAAM = :klantnaam AND KLANTEMAIL = :klantemail  AND BEGINDATUM = :begindatum AND EINDDATUM = :einddatum"
                };
                cmd.Parameters.Add("medewerkerid", medewerkerid);
                cmd.Parameters.Add("klantnaam", klantnaam);
                cmd.Parameters.Add("klantemail", klantemail);
                cmd.Parameters.Add("begindatum", begindatum);
                cmd.Parameters.Add("einddatum", einddatum);
                cmd.Parameters.Add("prijs", prijs);
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = (dr.GetInt32(0));
                    return id;
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

        public void ToevoegenArtikelContract(int ContractID , int ArtikelID)
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

                    CommandText = "INSERT INTO HUURARTIKEL (CONTRACTID,ARTIKELID) VALUES(:ContractID , :ArtikelID)"
                };
                cmd.Parameters.Add("ContractID", ContractID);
                cmd.Parameters.Add("ArtikelID", ArtikelID);

                cmd.ExecuteNonQuery();
            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
        }
        }

        public void ToevoegenBootContract(int ContractID, int BootID)
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

                    CommandText = "INSERT INTO HUURBOOT (CONTRACTID,BOOTID) VALUES(:ContractID , :BootID)"
                };
                cmd.Parameters.Add("ContractID", ContractID);
                cmd.Parameters.Add("BootID", BootID);

                cmd.ExecuteNonQuery();
                }
                catch (OracleException e)
                {
                    Console.WriteLine("Message: " + e.Message);
                }
            }
        }

        public void ToevoegenGebiedContract(int ContractID, int GebiedID)
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

                    CommandText = "INSERT INTO HUURGEBIED (CONTRACTID,GEBIEDID) VALUES(:ContractID , :GebiedID)"
                };
                cmd.Parameters.Add("ContractID", ContractID);
                cmd.Parameters.Add("GebiedID", GebiedID);

                cmd.ExecuteNonQuery();
            }
                catch (OracleException e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
        }
        }

        public void UpdateContractPrijs(decimal prijs , int id)
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

                    CommandText = "UPDATE HUURCONTRACT SET PRIJS = :prijs WHERE CONTRACTID = :id"
                };
                cmd.Parameters.Add("prijs", prijs);
                cmd.Parameters.Add("id", id);

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
