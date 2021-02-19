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

    public partial class PrijavaForma : Form
    {
        public static int uloga;
        public static int id;
        public static Korisnik prijavljeniKorisnik;

        string path = Directory.GetCurrentDirectory();

        static string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName);
        string startupPath2 = startupPath + "//Software//Pomoc.chm";
        // otvara se help pritiskom na tipku F1
        public PrijavaForma()
        {
            InitializeComponent();
            helpProvider1.HelpNamespace = startupPath2;
        }

        private void PrijavaForma_Load(object sender, EventArgs e)
        {


        }

        // Klikom na gumb Prijavi se, otvara se glavna forma

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();
            korisnik = Validacija.IzvrsiPrijavu(txtBoxKorisnickoIme.Text, txtBoxLozinka.Text);
            if (korisnik != null)
            {
                uloga = korisnik.ulogaKorisnika_iduloga;
                id = korisnik.idKorisnik;
                prijavljeniKorisnik = korisnik;
                this.Hide();
                GlavnaForma glavnaforma = new GlavnaForma(korisnik);
                glavnaforma.Show();
            }
            else
            {
                txtBoxKorisnickoIme.Text = "";
                txtBoxLozinka.Text = "";
                MessageBox.Show("Krivo uneseni podaci", "Neuspješna prijava");
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //klikom na gumb  otvara se forma za registraciju

        private void btnRegistracijaForma_Click(object sender, EventArgs e)
        {
            RegistracijaForma registracija = new RegistracijaForma();
            this.Hide();
            registracija.ShowDialog();
            this.Close();
        }


    }
   
}
