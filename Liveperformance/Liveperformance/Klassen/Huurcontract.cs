using Liveperformance.DatabaseKlassen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liveperformance.Klassen
{
    public class Huurcontract
    {
        public int ID { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public decimal Prijs { get; set; }

        public decimal Totaalartikelprijs;
        public decimal Totaalgebiedprijs;
        public decimal Totaalbootprijs;

        public List<Vaargebied> Vaargebieden = new List<Vaargebied>();
        public List<Boot> Boten = new List<Boot>();
        public List<Artikel> Artikelen = new List<Artikel>();
        public Klant Klant { get; set; }
        public Medewerker Medewerker { get; set; }

        DBVaargebied dbvaargebied = new DBVaargebied();
        DBBoot dbboot = new DBBoot();
        DBMedewerker dbmedewerkers = new DBMedewerker();
        DBArtikel dbartikelen = new DBArtikel();
        DBHuurcontract dbhuur = new DBHuurcontract();
        DBKlant dbklant = new DBKlant();

        public Huurcontract(int id , Medewerker medewerker, Klant klant , DateTime begindatum , DateTime einddatum , decimal prijs)
        {
            ID = id;
            Medewerker = medewerker;
            Klant = klant;
            BeginDatum = begindatum;
            EindDatum = einddatum;
            Prijs = prijs;
        }
        public Huurcontract(int id, Medewerker medewerker, Klant klant, List<Artikel> artikelen, List<Boot> boten , List<Vaargebied> vaargebieden , DateTime begindatum, DateTime einddatum, decimal prijs)
        {
            ID = id;
            Medewerker = medewerker;
            Klant = klant;
            Artikelen = artikelen;
            Boten = boten;
            Vaargebieden = vaargebieden;
            BeginDatum = begindatum;
            EindDatum = einddatum;
            Prijs = prijs;
        }

        public Huurcontract()
        {

        }

        public void ToevoegenContract(Medewerker medewerker, Klant klant, List<Boot> boten, List<Artikel> artikelen, List<Vaargebied> gebieden, DateTime begindatum, DateTime einddatum , bool bon , bool html)
        {
            dbklant.ToevoegenKlant(klant.Naam, klant.Email);
            int medewekerid = dbmedewerkers.GetMedewerkerIDbyNaam(medewerker.Naam);
            decimal prijs = 1;
            dbhuur.ToevoegenContract(medewekerid, klant.Naam, klant.Email, begindatum,einddatum,prijs);

            int Contractid = dbhuur.GetContractID(medewekerid, klant.Naam, klant.Email, begindatum, einddatum , prijs);

            foreach (Vaargebied gebied in gebieden)
            {
                if (gebieden.Count() > 5 && gebied.Motor == true && gebied.Spierkracht == true)
                {
                    decimal sluisgeld = 1 / 2;
                    decimal totaalgebiedprijs =+ gebied.Prijs + sluisgeld;
                    Totaalgebiedprijs = totaalgebiedprijs;
                }

                else
                {
                    decimal totaalgebiedprijs = +gebied.Prijs;
                    Totaalgebiedprijs = totaalgebiedprijs;
                }
                dbhuur.ToevoegenGebiedContract(Contractid, gebied.ID);
            }

            foreach (Boot boot in boten)
            {
                dbhuur.ToevoegenBootContract(Contractid, boot.ID);
                decimal totaalbootprijs =+ boot.Prijs;
                Totaalbootprijs = totaalbootprijs;
            }

            foreach (Artikel artikel in artikelen)
            {
                dbhuur.ToevoegenArtikelContract(Contractid, artikel.ID);
                decimal totaalartikelprijs =+ artikel.Prijs;
                Totaalartikelprijs = totaalartikelprijs;
            }

            double som = (einddatum - begindatum).TotalDays;
            int aantaldagen = Convert.ToInt32(som);

            if (aantaldagen == 0)
            {
                aantaldagen = 1;
            }
            decimal nieuwprijs = (Totaalartikelprijs + Totaalbootprijs + Totaalgebiedprijs) * aantaldagen;
            dbhuur.UpdateContractPrijs(nieuwprijs ,Contractid);

            Huurcontract nieuwcontract = new Huurcontract(Contractid,medewerker,klant,artikelen,boten,gebieden,begindatum,einddatum,prijs);

            // niet genoeg output maar zit in tijdnood
            if (bon)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "DefaultOutputName.txt";
                save.Filter = "Text File | *.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    writer.WriteLine(nieuwcontract.ToString());
                    writer.Dispose();
                    writer.Close();
                }
            }
            else if (html)
            {
                    SaveFileDialog save = new SaveFileDialog();
                    save.FileName = "DefaultOutputName.txt";
                    save.Filter = "Text File | *.html";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(save.OpenFile());
                        writer.WriteLine(nieuwcontract.ToString());
                        writer.Dispose();
                        writer.Close();
                    }
                }
            


        }
        public void ToevoegenVaargebied(string naam , string motor , string spierkracht , decimal prijs)
        {
            dbvaargebied.ToevoegenVaargebied(naam, motor, spierkracht, prijs);
            int id = dbvaargebied.GetGebiedIDByNaam(naam);
            bool Motor = Convert.ToBoolean(motor);
            bool Spier = Convert.ToBoolean(spierkracht);
            Vaargebied vaargebied = new Vaargebied(id,naam,Motor,Spier,prijs);
        }

        public List<Huurcontract> ToonOverzicht()
        {

            List<Huurcontract> Contracten = dbhuur.AlleHuurcontracten();
            return Contracten;
        }

        public void ToonTemperatuur()
        {

        }

        public List<Boot> ToonBoten()
        {
            List<Boot> Boten = dbboot.AlleBoten();
            return Boten;
        }
        public List<Medewerker> ToonMedewerkers()
        {
            List<Medewerker> Medewerkers = dbmedewerkers.AlleMedewerkers();
            return Medewerkers;
        }

        public List<Artikel> ToonArtikelen()
        {
            List<Artikel> Artikelen = dbartikelen.AlleArtikelen();
            return Artikelen;
        }
        public List<Vaargebied> ToonVaargebieden()
        {
            List<Vaargebied> Gebieden = dbvaargebied.AlleVaarGebieden();
            return Gebieden;
        }



        public override string ToString()
        {
            return ID.ToString() + " " + "Verhuurder: " + Medewerker.Naam + " " + "Klant: " + Klant.Naam + " " + "Begindatum: " + BeginDatum + " " + "Einddatum: " + EindDatum;
        }
    }
}
