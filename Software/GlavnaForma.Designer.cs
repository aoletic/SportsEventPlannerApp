namespace SportsEventPlanner
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnPregledTimovaNatjecatelja = new System.Windows.Forms.Button();
            this.btnPrijavaNatjecanje = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnNatjecateljskoStablo = new System.Windows.Forms.Button();
            this.btnSportovi = new System.Windows.Forms.Button();
            this.btnDogadaji = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statistikaKontrola1 = new SportsEventPlanner.StatistikaKontrola();
            this.prijavaNatjecanjeKontrola1 = new SportsEventPlanner.PrijavaNatjecanjeKontrola();
            this.pregledTimovaNatjecateljaKontrola1 = new SportsEventPlanner.PregledTimovaNatjecateljaKontrola();
            this.natjecateljskoStabloKontrola1 = new SportsEventPlanner.NatjecateljskoStabloKontrola();
            this.dogadajiKontrola1 = new SportsEventPlanner.DogadajiKontrola();
            this.sportoviKontrola1 = new SportsEventPlanner.SportoviKontrola();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.btnOdjava);
            this.panel1.Controls.Add(this.btnPregledTimovaNatjecatelja);
            this.panel1.Controls.Add(this.btnPrijavaNatjecanje);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnStatistika);
            this.panel1.Controls.Add(this.btnNatjecateljskoStablo);
            this.panel1.Controls.Add(this.btnSportovi);
            this.panel1.Controls.Add(this.btnDogadaji);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 560);
            this.panel1.TabIndex = 0;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Location = new System.Drawing.Point(32, 523);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(81, 27);
            this.btnOdjava.TabIndex = 6;
            this.btnOdjava.Text = "Odjavi se";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnPregledTimovaNatjecatelja
            // 
            this.btnPregledTimovaNatjecatelja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPregledTimovaNatjecatelja.FlatAppearance.BorderSize = 0;
            this.btnPregledTimovaNatjecatelja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledTimovaNatjecatelja.ForeColor = System.Drawing.Color.DarkGray;
            this.helpProvider.SetHelpKeyword(this.btnPregledTimovaNatjecatelja, "pregled");
            this.helpProvider.SetHelpNavigator(this.btnPregledTimovaNatjecatelja, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnPregledTimovaNatjecatelja.Location = new System.Drawing.Point(0, 375);
            this.btnPregledTimovaNatjecatelja.Margin = new System.Windows.Forms.Padding(2);
            this.btnPregledTimovaNatjecatelja.Name = "btnPregledTimovaNatjecatelja";
            this.helpProvider.SetShowHelp(this.btnPregledTimovaNatjecatelja, true);
            this.btnPregledTimovaNatjecatelja.Size = new System.Drawing.Size(150, 67);
            this.btnPregledTimovaNatjecatelja.TabIndex = 11;
            this.btnPregledTimovaNatjecatelja.Text = "Pregled timova i natjecatelja";
            this.btnPregledTimovaNatjecatelja.UseVisualStyleBackColor = false;
            this.btnPregledTimovaNatjecatelja.Click += new System.EventHandler(this.btnPregledTimovaNatjecatelja_Click);
            // 
            // btnPrijavaNatjecanje
            // 
            this.btnPrijavaNatjecanje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPrijavaNatjecanje.FlatAppearance.BorderSize = 0;
            this.btnPrijavaNatjecanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijavaNatjecanje.ForeColor = System.Drawing.Color.DarkGray;
            this.helpProvider.SetHelpKeyword(this.btnPrijavaNatjecanje, "prijavanatjecanje");
            this.helpProvider.SetHelpNavigator(this.btnPrijavaNatjecanje, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnPrijavaNatjecanje.Location = new System.Drawing.Point(-2, 303);
            this.btnPrijavaNatjecanje.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrijavaNatjecanje.Name = "btnPrijavaNatjecanje";
            this.helpProvider.SetShowHelp(this.btnPrijavaNatjecanje, true);
            this.btnPrijavaNatjecanje.Size = new System.Drawing.Size(150, 67);
            this.btnPrijavaNatjecanje.TabIndex = 10;
            this.btnPrijavaNatjecanje.Text = "Prijava u natjecanje";
            this.btnPrijavaNatjecanje.UseVisualStyleBackColor = false;
            this.btnPrijavaNatjecanje.Click += new System.EventHandler(this.btnPrijavaNatjecanje_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.pctBoxLogo);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 81);
            this.panel2.TabIndex = 9;
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxLogo.Image")));
            this.pctBoxLogo.Location = new System.Drawing.Point(0, -2);
            this.pctBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(150, 84);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxLogo.TabIndex = 8;
            this.pctBoxLogo.TabStop = false;
            // 
            // btnStatistika
            // 
            this.btnStatistika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnStatistika.FlatAppearance.BorderSize = 0;
            this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistika.ForeColor = System.Drawing.Color.DarkGray;
            this.helpProvider.SetHelpKeyword(this.btnStatistika, "statistika");
            this.helpProvider.SetHelpNavigator(this.btnStatistika, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnStatistika.Location = new System.Drawing.Point(0, 446);
            this.btnStatistika.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistika.Name = "btnStatistika";
            this.helpProvider.SetShowHelp(this.btnStatistika, true);
            this.btnStatistika.Size = new System.Drawing.Size(150, 67);
            this.btnStatistika.TabIndex = 7;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = false;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnNatjecateljskoStablo
            // 
            this.btnNatjecateljskoStablo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnNatjecateljskoStablo.FlatAppearance.BorderSize = 0;
            this.btnNatjecateljskoStablo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNatjecateljskoStablo.ForeColor = System.Drawing.Color.DarkGray;
            this.helpProvider.SetHelpKeyword(this.btnNatjecateljskoStablo, "stablo");
            this.helpProvider.SetHelpNavigator(this.btnNatjecateljskoStablo, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnNatjecateljskoStablo.Location = new System.Drawing.Point(0, 232);
            this.btnNatjecateljskoStablo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNatjecateljskoStablo.Name = "btnNatjecateljskoStablo";
            this.helpProvider.SetShowHelp(this.btnNatjecateljskoStablo, true);
            this.btnNatjecateljskoStablo.Size = new System.Drawing.Size(150, 67);
            this.btnNatjecateljskoStablo.TabIndex = 4;
            this.btnNatjecateljskoStablo.Text = "Natjecateljsko stablo";
            this.btnNatjecateljskoStablo.UseVisualStyleBackColor = false;
            this.btnNatjecateljskoStablo.Click += new System.EventHandler(this.btnNatjecateljskoStablo_Click);
            // 
            // btnSportovi
            // 
            this.btnSportovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSportovi.FlatAppearance.BorderSize = 0;
            this.btnSportovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSportovi.ForeColor = System.Drawing.Color.DarkGray;
            this.helpProvider.SetHelpKeyword(this.btnSportovi, "sportovi");
            this.helpProvider.SetHelpNavigator(this.btnSportovi, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnSportovi.Location = new System.Drawing.Point(0, 160);
            this.btnSportovi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSportovi.Name = "btnSportovi";
            this.helpProvider.SetShowHelp(this.btnSportovi, true);
            this.btnSportovi.Size = new System.Drawing.Size(150, 67);
            this.btnSportovi.TabIndex = 3;
            this.btnSportovi.Text = "Sportovi";
            this.btnSportovi.UseVisualStyleBackColor = false;
            this.btnSportovi.Click += new System.EventHandler(this.btnSportovi_Click);
            // 
            // btnDogadaji
            // 
            this.btnDogadaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDogadaji.FlatAppearance.BorderSize = 0;
            this.btnDogadaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDogadaji.ForeColor = System.Drawing.Color.DarkGray;
            this.helpProvider.SetHelpKeyword(this.btnDogadaji, "dogadaji");
            this.helpProvider.SetHelpNavigator(this.btnDogadaji, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnDogadaji.Location = new System.Drawing.Point(2, 89);
            this.btnDogadaji.Margin = new System.Windows.Forms.Padding(2);
            this.btnDogadaji.Name = "btnDogadaji";
            this.helpProvider.SetShowHelp(this.btnDogadaji, true);
            this.btnDogadaji.Size = new System.Drawing.Size(150, 67);
            this.btnDogadaji.TabIndex = 2;
            this.btnDogadaji.Text = "Događaji";
            this.btnDogadaji.UseVisualStyleBackColor = false;
            this.btnDogadaji.Click += new System.EventHandler(this.btnDogadaji_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -298);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 778);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statistikaKontrola1);
            this.panel3.Controls.Add(this.prijavaNatjecanjeKontrola1);
            this.panel3.Controls.Add(this.pregledTimovaNatjecateljaKontrola1);
            this.panel3.Controls.Add(this.natjecateljskoStabloKontrola1);
            this.panel3.Controls.Add(this.dogadajiKontrola1);
            this.panel3.Controls.Add(this.sportoviKontrola1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(149, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 560);
            this.panel3.TabIndex = 2;
            // 
            // statistikaKontrola1
            // 
            this.statistikaKontrola1.ForeColor = System.Drawing.Color.Black;
            this.statistikaKontrola1.Location = new System.Drawing.Point(0, 2);
            this.statistikaKontrola1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statistikaKontrola1.Name = "statistikaKontrola1";
            this.statistikaKontrola1.Size = new System.Drawing.Size(901, 560);
            this.statistikaKontrola1.TabIndex = 5;
            // 
            // prijavaNatjecanjeKontrola1
            // 
            this.prijavaNatjecanjeKontrola1.Location = new System.Drawing.Point(0, 0);
            this.prijavaNatjecanjeKontrola1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prijavaNatjecanjeKontrola1.Name = "prijavaNatjecanjeKontrola1";
            this.prijavaNatjecanjeKontrola1.Size = new System.Drawing.Size(901, 560);
            this.prijavaNatjecanjeKontrola1.TabIndex = 4;
            // 
            // pregledTimovaNatjecateljaKontrola1
            // 
            this.pregledTimovaNatjecateljaKontrola1.Location = new System.Drawing.Point(0, 0);
            this.pregledTimovaNatjecateljaKontrola1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pregledTimovaNatjecateljaKontrola1.Name = "pregledTimovaNatjecateljaKontrola1";
            this.pregledTimovaNatjecateljaKontrola1.Size = new System.Drawing.Size(901, 560);
            this.pregledTimovaNatjecateljaKontrola1.TabIndex = 3;
            // 
            // natjecateljskoStabloKontrola1
            // 
            this.natjecateljskoStabloKontrola1.Location = new System.Drawing.Point(0, 0);
            this.natjecateljskoStabloKontrola1.Margin = new System.Windows.Forms.Padding(2);
            this.natjecateljskoStabloKontrola1.Name = "natjecateljskoStabloKontrola1";
            this.natjecateljskoStabloKontrola1.Size = new System.Drawing.Size(901, 560);
            this.natjecateljskoStabloKontrola1.TabIndex = 2;
            // 
            // dogadajiKontrola1
            // 
            this.dogadajiKontrola1.Location = new System.Drawing.Point(0, 0);
            this.dogadajiKontrola1.Margin = new System.Windows.Forms.Padding(2);
            this.dogadajiKontrola1.Name = "dogadajiKontrola1";
            this.dogadajiKontrola1.Size = new System.Drawing.Size(901, 560);
            this.dogadajiKontrola1.TabIndex = 1;
            // 
            // sportoviKontrola1
            // 
            this.sportoviKontrola1.Location = new System.Drawing.Point(0, 0);
            this.sportoviKontrola1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sportoviKontrola1.Name = "sportoviKontrola1";
            this.sportoviKontrola1.Size = new System.Drawing.Size(901, 560);
            this.sportoviKontrola1.TabIndex = 0;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider.SetHelpKeyword(this, "glavnaforma");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GlavnaForma";
            this.helpProvider.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Event Planner";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnNatjecateljskoStablo;
        private System.Windows.Forms.Button btnSportovi;
        private System.Windows.Forms.Button btnDogadaji;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private SportoviKontrola sportoviKontrola1;
        private DogadajiKontrola dogadajiKontrola1;
        private NatjecateljskoStabloKontrola natjecateljskoStabloKontrola1;
        private PregledTimovaNatjecateljaKontrola pregledTimovaNatjecateljaKontrola1;
        private PrijavaNatjecanjeKontrola prijavaNatjecanjeKontrola1;
        private StatistikaKontrola statistikaKontrola1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private System.Windows.Forms.Button btnPregledTimovaNatjecatelja;
        private System.Windows.Forms.Button btnPrijavaNatjecanje;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}