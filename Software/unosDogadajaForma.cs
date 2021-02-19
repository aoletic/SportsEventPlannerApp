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
    public partial class unosDogadajaForma : Form
    {

        //Referenca na postojeći dogadaj.
        DogadajiRepozitorij dogadajiRepozitorij = new DogadajiRepozitorij();

        private Dogadaj Dogadaj = null;
        public unosDogadajaForma()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor forme koji pozivam kada mijenjam postojeći tim.
        /// </summary>
        /// <param name="odabraniTim">Postojeći tim čije podatke mijenjam.</param>
        public unosDogadajaForma(Dogadaj odabraniDogadaj)
        {
            InitializeComponent();
            Dogadaj = odabraniDogadaj;
        }


        private void unosDogadajaForma_Load(object sender, EventArgs e)

        {
            cmbVrstaSporta.DataSource = SportoviRepozitorij.DohvatiSportovePrikaz();
            if(Dogadaj!= null)
            {

                txtBoxImeDogadaja.Text = Dogadaj.ImeDogadaj;
                dtpDatumPocetka.Value = DateTime.Parse(Dogadaj.DatumPocetkaDogadaj);
                dtpDatumZavrsetka.Value = DateTime.Parse(Dogadaj.DatumZavrsetkaDogadaj);
                txtBoxMinTimova.Text = Dogadaj.MinBrojTimova.ToString();
                txtBoxMaxTim.Text = Dogadaj.MaxBrojTimova.ToString();
                cmbVrstaSporta.DataSource = SportoviRepozitorij.DohvatiSportovePrikaz();

            }

            
        }

        private void btnSpremiDogadaj_Click(object sender, EventArgs e)
        {
            Sport sport = cmbVrstaSporta.SelectedItem as Sport;

            if (Dogadaj == null)
            {

                Dogadaj = new Dogadaj();
            }
            try
            {

           
            Dogadaj.ImeDogadaj = txtBoxImeDogadaja.Text; 
            Dogadaj.DatumPocetkaDogadaj = dtpDatumPocetka.Value.ToString();
            Dogadaj.DatumZavrsetkaDogadaj = dtpDatumZavrsetka.Value.ToString();
            Dogadaj.MinBrojTimova =int.Parse(txtBoxMinTimova.Text);
            Dogadaj.MaxBrojTimova=int.Parse(txtBoxMaxTim.Text);
            cmbVrstaSporta.DataSource = SportoviRepozitorij.DohvatiSportovePrikaz();
            Dogadaj.idSporta = sport.IdSport;
            Dogadaj.idKorisnik = PrijavaForma.prijavljeniKorisnik.idKorisnik;
                if (txtBoxImeDogadaja.Text == "")
                {
                    MessageBox.Show("Nisu ispravno uneseni podaci!");
                }
                else { 
            DogadajiRepozitorij.Spremi(Dogadaj);
                    this.Close();
                }
               
            }
            catch
            {
                MessageBox.Show("Nisu ispravno uneseni podaci!");
            }
        }

   
    }


}

  

