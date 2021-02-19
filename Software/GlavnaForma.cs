using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SportsEventPlanner
{
    public partial class GlavnaForma : Form
    {
        Korisnik prijavljeniKorisnik = new Korisnik();
        // otvara se help pritiskom na tipku F1
        string path = Directory.GetCurrentDirectory();

        static string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName);
        string startupPath2 = startupPath + "//Software//Pomoc.chm";

        //inicijalizacija glavne forme putem koje se po defaultu otvara kontrola dogadaji
        public GlavnaForma(Korisnik korisnik)
        {
            InitializeComponent();
            dogadajiKontrola1.BringToFront();
            helpProvider.HelpNamespace = startupPath2;

        }

        // klikom na button Sportovi otvara se kontrola za Sportove
        private void btnSportovi_Click(object sender, EventArgs e)
        {
            sportoviKontrola1.BringToFront();
        }

        // klikom na button Dogadaji otvara se kontrola za Događaje

        private void btnDogadaji_Click(object sender, EventArgs e)
        {
            dogadajiKontrola1.BringToFront();

        }

        // klikom na button Natjecateljsko stablo otvara se kontrola za Natjecateljsko stablo

        private void btnNatjecateljskoStablo_Click(object sender, EventArgs e)
        {
            natjecateljskoStabloKontrola1.BringToFront();
        }

        // klikom na button Statistika otvara se kontrola za Statistiku
        private void btnStatistika_Click(object sender, EventArgs e)
        {
            statistikaKontrola1.BringToFront();
        }

        // klikom na button Prijava u natjecanje otvara se kontrola za Prijavu u natjecanje

        private void btnPrijavaNatjecanje_Click(object sender, EventArgs e)
        {
            prijavaNatjecanjeKontrola1.BringToFront();
        }

        // klikom na button Pregled timova i natjecatelja otvara se kontrola za Pregled timova i natjecatelja
        private void btnPregledTimovaNatjecatelja_Click(object sender, EventArgs e)
        {
            pregledTimovaNatjecateljaKontrola1.BringToFront();
        }
   

        // klikom na gumb odjava, trenutačni korisnik se odjavljuje, glavna forma se zatvara te se ponovo otvara forma za login
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            PrijavaForma prijavaForma = new PrijavaForma();
            this.Hide();
            prijavaForma.Show();
        }
    }
}
