using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sportovi;

namespace SportsEventPlanner
{
    public partial class unosSportovaForma : Form
    {
        SportoviRepozitorij sportoviRepozitorij = new SportoviRepozitorij();
        private Sport Sport = null;

        public unosSportovaForma()
        {
            InitializeComponent();
        }

        public unosSportovaForma(Sportovi.Sport odabraniSport)
        {
            InitializeComponent();
            Sport = odabraniSport;
        }


        private void btnSpremiSport_Click(object sender, EventArgs e)
        {
            if (Sport == null)
            {

                Sport = new Sport();
            }
            if (txtBoxNazivSporta.Text == "")
            {
                MessageBox.Show("Krivo uneseni podaci");
            }
            else
            {


                try
                {


                    Sport.NazivSport = txtBoxNazivSporta.Text;
                    Sport.BrojClanovaTim = int.Parse(txtBoxBroj.Text);
                    SportoviRepozitorij.SpremiSport(Sport, PrijavaForma.prijavljeniKorisnik.idKorisnik);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Nisu ispravno unseni podaci!");
                }
            }
        }

        private void unosSportovaForma_Load(object sender, EventArgs e)
        {
            if (Sport != null)
            {
                txtBoxNazivSporta.Text = Sport.NazivSport;
                txtBoxBroj.Text = Sport.BrojClanovaTim.ToString();
            }

        }
    }
}
