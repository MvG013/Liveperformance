namespace Liveperformance
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbBoten = new System.Windows.Forms.ListBox();
            this.LbArtikelen = new System.Windows.Forms.ListBox();
            this.LbVaargebieden = new System.Windows.Forms.ListBox();
            this.LbMedewerkers = new System.Windows.Forms.ListBox();
            this.TbKlantNaam = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUitvoeren = new System.Windows.Forms.Button();
            this.BtnTemp = new System.Windows.Forms.Button();
            this.BtnVoorstel = new System.Windows.Forms.Button();
            this.TbBudget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbOverzicht = new System.Windows.Forms.ListBox();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbLocatie = new System.Windows.Forms.TextBox();
            this.CbBon = new System.Windows.Forms.CheckBox();
            this.CbHTML = new System.Windows.Forms.CheckBox();
            this.TbGebied = new System.Windows.Forms.TextBox();
            this.BtnGebied = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TbPrijs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DTPEinddatum = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DTPBegindatum = new System.Windows.Forms.DateTimePicker();
            this.BtnOverzicht = new System.Windows.Forms.Button();
            this.CbSpierkracht = new System.Windows.Forms.CheckBox();
            this.CbMotor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LbBoten
            // 
            this.LbBoten.FormattingEnabled = true;
            this.LbBoten.Location = new System.Drawing.Point(605, 192);
            this.LbBoten.Name = "LbBoten";
            this.LbBoten.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbBoten.Size = new System.Drawing.Size(164, 199);
            this.LbBoten.TabIndex = 0;
            // 
            // LbArtikelen
            // 
            this.LbArtikelen.FormattingEnabled = true;
            this.LbArtikelen.Location = new System.Drawing.Point(406, 192);
            this.LbArtikelen.Name = "LbArtikelen";
            this.LbArtikelen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbArtikelen.Size = new System.Drawing.Size(164, 199);
            this.LbArtikelen.TabIndex = 1;
            // 
            // LbVaargebieden
            // 
            this.LbVaargebieden.FormattingEnabled = true;
            this.LbVaargebieden.Location = new System.Drawing.Point(205, 192);
            this.LbVaargebieden.Name = "LbVaargebieden";
            this.LbVaargebieden.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbVaargebieden.Size = new System.Drawing.Size(164, 199);
            this.LbVaargebieden.TabIndex = 2;
            // 
            // LbMedewerkers
            // 
            this.LbMedewerkers.FormattingEnabled = true;
            this.LbMedewerkers.Location = new System.Drawing.Point(7, 192);
            this.LbMedewerkers.Name = "LbMedewerkers";
            this.LbMedewerkers.Size = new System.Drawing.Size(164, 199);
            this.LbMedewerkers.TabIndex = 3;
            // 
            // TbKlantNaam
            // 
            this.TbKlantNaam.Location = new System.Drawing.Point(461, 406);
            this.TbKlantNaam.Name = "TbKlantNaam";
            this.TbKlantNaam.Size = new System.Drawing.Size(100, 20);
            this.TbKlantNaam.TabIndex = 4;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(461, 432);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(100, 20);
            this.TbEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Klantnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email:";
            // 
            // BtnUitvoeren
            // 
            this.BtnUitvoeren.Location = new System.Drawing.Point(461, 510);
            this.BtnUitvoeren.Name = "BtnUitvoeren";
            this.BtnUitvoeren.Size = new System.Drawing.Size(75, 23);
            this.BtnUitvoeren.TabIndex = 8;
            this.BtnUitvoeren.Text = "Uitvoeren";
            this.BtnUitvoeren.UseVisualStyleBackColor = true;
            this.BtnUitvoeren.Click += new System.EventHandler(this.BtnUitvoeren_Click);
            // 
            // BtnTemp
            // 
            this.BtnTemp.Location = new System.Drawing.Point(893, 89);
            this.BtnTemp.Name = "BtnTemp";
            this.BtnTemp.Size = new System.Drawing.Size(75, 23);
            this.BtnTemp.TabIndex = 9;
            this.BtnTemp.Text = "Temperatuur";
            this.BtnTemp.UseVisualStyleBackColor = true;
            // 
            // BtnVoorstel
            // 
            this.BtnVoorstel.Location = new System.Drawing.Point(893, 60);
            this.BtnVoorstel.Name = "BtnVoorstel";
            this.BtnVoorstel.Size = new System.Drawing.Size(75, 23);
            this.BtnVoorstel.TabIndex = 10;
            this.BtnVoorstel.Text = "Voorstel";
            this.BtnVoorstel.UseVisualStyleBackColor = true;
            this.BtnVoorstel.Click += new System.EventHandler(this.BtnVoorstel_Click);
            // 
            // TbBudget
            // 
            this.TbBudget.Location = new System.Drawing.Point(881, 8);
            this.TbBudget.Name = "TbBudget";
            this.TbBudget.Size = new System.Drawing.Size(100, 20);
            this.TbBudget.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(831, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Budget:";
            // 
            // LbOverzicht
            // 
            this.LbOverzicht.FormattingEnabled = true;
            this.LbOverzicht.Location = new System.Drawing.Point(804, 192);
            this.LbOverzicht.Name = "LbOverzicht";
            this.LbOverzicht.Size = new System.Drawing.Size(164, 199);
            this.LbOverzicht.TabIndex = 13;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Location = new System.Drawing.Point(12, 12);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(87, 48);
            this.BtnAdmin.TabIndex = 15;
            this.BtnAdmin.Text = "Admin paneel";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Medewerkers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vaargebieden:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Artikelen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Boten:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(801, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Overzicht:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(830, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Locatie:";
            // 
            // TbLocatie
            // 
            this.TbLocatie.Location = new System.Drawing.Point(881, 34);
            this.TbLocatie.Name = "TbLocatie";
            this.TbLocatie.Size = new System.Drawing.Size(100, 20);
            this.TbLocatie.TabIndex = 21;
            // 
            // CbBon
            // 
            this.CbBon.AutoSize = true;
            this.CbBon.Location = new System.Drawing.Point(551, 514);
            this.CbBon.Name = "CbBon";
            this.CbBon.Size = new System.Drawing.Size(75, 17);
            this.CbBon.TabIndex = 23;
            this.CbBon.Text = "Tekst Bon";
            this.CbBon.UseVisualStyleBackColor = true;
            // 
            // CbHTML
            // 
            this.CbHTML.AutoSize = true;
            this.CbHTML.Location = new System.Drawing.Point(629, 514);
            this.CbHTML.Name = "CbHTML";
            this.CbHTML.Size = new System.Drawing.Size(78, 17);
            this.CbHTML.TabIndex = 24;
            this.CbHTML.Text = "HTML Bon";
            this.CbHTML.UseVisualStyleBackColor = true;
            // 
            // TbGebied
            // 
            this.TbGebied.Location = new System.Drawing.Point(699, 8);
            this.TbGebied.Name = "TbGebied";
            this.TbGebied.Size = new System.Drawing.Size(100, 20);
            this.TbGebied.TabIndex = 25;
            // 
            // BtnGebied
            // 
            this.BtnGebied.Location = new System.Drawing.Point(699, 110);
            this.BtnGebied.Name = "BtnGebied";
            this.BtnGebied.Size = new System.Drawing.Size(75, 23);
            this.BtnGebied.TabIndex = 26;
            this.BtnGebied.Text = "Uitvoeren";
            this.BtnGebied.UseVisualStyleBackColor = true;
            this.BtnGebied.Click += new System.EventHandler(this.BtnGebied_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Vaargebied:";
            // 
            // TbPrijs
            // 
            this.TbPrijs.Location = new System.Drawing.Point(699, 34);
            this.TbPrijs.Name = "TbPrijs";
            this.TbPrijs.Size = new System.Drawing.Size(53, 20);
            this.TbPrijs.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(664, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Prijs:";
            // 
            // DTPEinddatum
            // 
            this.DTPEinddatum.Location = new System.Drawing.Point(461, 484);
            this.DTPEinddatum.Name = "DTPEinddatum";
            this.DTPEinddatum.Size = new System.Drawing.Size(200, 20);
            this.DTPEinddatum.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(397, 488);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Einddatum:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(389, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Begindatum:";
            // 
            // DTPBegindatum
            // 
            this.DTPBegindatum.Location = new System.Drawing.Point(461, 458);
            this.DTPBegindatum.Name = "DTPBegindatum";
            this.DTPBegindatum.Size = new System.Drawing.Size(200, 20);
            this.DTPBegindatum.TabIndex = 32;
            // 
            // BtnOverzicht
            // 
            this.BtnOverzicht.Location = new System.Drawing.Point(829, 397);
            this.BtnOverzicht.Name = "BtnOverzicht";
            this.BtnOverzicht.Size = new System.Drawing.Size(116, 23);
            this.BtnOverzicht.TabIndex = 35;
            this.BtnOverzicht.Text = "Toon overzicht";
            this.BtnOverzicht.UseVisualStyleBackColor = true;
            this.BtnOverzicht.Click += new System.EventHandler(this.BtnOverzicht_Click);
            // 
            // CbSpierkracht
            // 
            this.CbSpierkracht.AutoSize = true;
            this.CbSpierkracht.Location = new System.Drawing.Point(700, 87);
            this.CbSpierkracht.Name = "CbSpierkracht";
            this.CbSpierkracht.Size = new System.Drawing.Size(80, 17);
            this.CbSpierkracht.TabIndex = 37;
            this.CbSpierkracht.Text = "Spierkracht";
            this.CbSpierkracht.UseVisualStyleBackColor = true;
            // 
            // CbMotor
            // 
            this.CbMotor.AutoSize = true;
            this.CbMotor.Location = new System.Drawing.Point(700, 64);
            this.CbMotor.Name = "CbMotor";
            this.CbMotor.Size = new System.Drawing.Size(53, 17);
            this.CbMotor.TabIndex = 36;
            this.CbMotor.Text = "Motor";
            this.CbMotor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 609);
            this.Controls.Add(this.CbSpierkracht);
            this.Controls.Add(this.CbMotor);
            this.Controls.Add(this.BtnOverzicht);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DTPBegindatum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DTPEinddatum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TbPrijs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnGebied);
            this.Controls.Add(this.TbGebied);
            this.Controls.Add(this.CbHTML);
            this.Controls.Add(this.CbBon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbLocatie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.LbOverzicht);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbBudget);
            this.Controls.Add(this.BtnVoorstel);
            this.Controls.Add(this.BtnTemp);
            this.Controls.Add(this.BtnUitvoeren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbKlantNaam);
            this.Controls.Add(this.LbMedewerkers);
            this.Controls.Add(this.LbVaargebieden);
            this.Controls.Add(this.LbArtikelen);
            this.Controls.Add(this.LbBoten);
            this.Name = "Form1";
            this.Text = "Botenverhuurbedrijf ’t Sloepke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbBoten;
        private System.Windows.Forms.ListBox LbArtikelen;
        private System.Windows.Forms.ListBox LbVaargebieden;
        private System.Windows.Forms.ListBox LbMedewerkers;
        private System.Windows.Forms.TextBox TbKlantNaam;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUitvoeren;
        private System.Windows.Forms.Button BtnTemp;
        private System.Windows.Forms.Button BtnVoorstel;
        private System.Windows.Forms.TextBox TbBudget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbOverzicht;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbLocatie;
        private System.Windows.Forms.CheckBox CbBon;
        private System.Windows.Forms.CheckBox CbHTML;
        private System.Windows.Forms.TextBox TbGebied;
        private System.Windows.Forms.Button BtnGebied;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbPrijs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DTPEinddatum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DTPBegindatum;
        private System.Windows.Forms.Button BtnOverzicht;
        private System.Windows.Forms.CheckBox CbSpierkracht;
        private System.Windows.Forms.CheckBox CbMotor;
    }
}

