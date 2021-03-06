﻿using Liveperformance.Klassen;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liveperformance.DatabaseKlassen
{
   public  class DBArtikel : Database
    {
        public List<Artikel> AlleArtikelen()
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                { 
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                List<Artikel> Artikelen = new List<Artikel>();

                OracleCommand cmd = new OracleCommand
                {
                    Connection = conn,
                    BindByName = true,
                    CommandText =
                        "SELECT * FROM ARTIKEL"
                };
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = (dr.GetInt32(0));
                    string naam = (dr.GetString(1));
                    decimal prijs = (dr.GetDecimal(2));
                    string beschrijving = (dr.GetString(3));

                    Artikel ToAdd = new Artikel(id, naam, prijs,beschrijving);
                    Artikelen.Add(ToAdd);
                }
                return Artikelen;
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
