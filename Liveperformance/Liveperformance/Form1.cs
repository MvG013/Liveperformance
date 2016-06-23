using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Liveperformance.Klassen;
using System.IO;

namespace Liveperformance
{
    public partial class Form1 : Form
    {
        Huurcontract huurcontract = new Huurcontract();
        public Form1()
        {
            InitializeComponent();
            LbBoten.DataSource = huurcontract.ToonBoten();
            LbVaargebieden.DataSource = huurcontract.ToonVaargebieden();
            LbMedewerkers.DataSource = huurcontract.ToonMedewerkers();
            LbArtikelen.DataSource = huurcontract.ToonArtikelen();
        }

        private void BtnGebied_Click(object sender, EventArgs e)
        {
            string naam = TbGebied.Text;
            decimal prijs = Convert.ToDecimal(TbPrijs.Text);
            string motor = Convert.ToString(CbMotor.Checked);
            string spier = Convert.ToString(CbSpierkracht.Checked);
            huurcontract.ToevoegenVaargebied(naam, motor, spier, prijs);
            TbGebied.Clear();
            TbPrijs.Clear();
            CbMotor.Checked = false;
            CbSpierkracht.Checked = false;

        }

        private void BtnVoorstel_Click(object sender, EventArgs e)
        {
            decimal budget = Convert.ToDecimal(TbBudget.Text);
            string locatie = TbLocatie.Text;
        }

        private void BtnUitvoeren_Click(object sender, EventArgs e)
        {
            Medewerker medewerker = (Medewerker)LbMedewerkers.SelectedItem;
            Klant klant = new Klant(TbKlantNaam.Text , TbEmail.Text);
            DateTime begindatum = DTPBegindatum.Value.Date;
            DateTime einddatum = DTPEinddatum.Value.Date;

            List<Vaargebied> gebieden = LbVaargebieden.SelectedItems.Cast<Vaargebied>().ToList();
            List<Boot> boten = LbBoten.SelectedItems.Cast<Boot>().ToList();
            List<Artikel> artikelen = LbArtikelen.SelectedItems.Cast<Artikel>().ToList();

            huurcontract.ToevoegenContract(medewerker,klant, boten, artikelen, gebieden, begindatum, einddatum,CbBon.Checked,CbHTML.Checked);

            TbKlantNaam.Clear();
            TbEmail.Clear();
            DTPBegindatum.ResetText();
            DTPEinddatum.ResetText();
            LbArtikelen.ClearSelected();
            LbBoten.ClearSelected();
            LbMedewerkers.ClearSelected();
            LbOverzicht.ClearSelected();
            LbVaargebieden.ClearSelected();

        }

        private void BtnOverzicht_Click(object sender, EventArgs e)
        {
           LbOverzicht.DataSource = huurcontract.ToonOverzicht();
        }

    }
}
