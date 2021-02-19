using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsEventPlanner
{
    public partial class DogadajiKontrola : UserControl
    {

        public DogadajiKontrola()
        {
            InitializeComponent();
            if(PrijavaForma.uloga > 2)
            {
                btnDodajDogadaj.Hide();
                btnAzurirajDogadaj.Hide();
                btnObrisiDogadaj.Hide();
            }
            
        }

        // klikom na gumb Dodaj dogadaj, otvara se nova forma za unos događaja
        private void btnDodajDogadaj_Click(object sender, EventArgs e)
        {
           unosDogadajaForma unosDogadaja = new unosDogadajaForma();
           unosDogadaja.ShowDialog();
           OsvjeziDogadaje(); 
        }

        // klikom na gumb Azuriraj dogadaj, otvara se forma za azuriranje dogadaja
        private void btnAzurirajDogadaj_Click(object sender, EventArgs e)
        {
            if (dgvDogadaji.SelectedRows.Count > 0)
            {
                Dogadaj odabraniDogadaj = dgvDogadaji.CurrentRow.DataBoundItem as Dogadaj;
                if (PrijavaForma.prijavljeniKorisnik.ulogaKorisnika_iduloga > 1)
                {
                    if (odabraniDogadaj.idKorisnik != PrijavaForma.prijavljeniKorisnik.idKorisnik)
                    {
                        MessageBox.Show("Niste kreirali odabrani događaj za ažuriranje!");
                    }
                    else
                    {
                        unosDogadajaForma unosDogadaja = new unosDogadajaForma(odabraniDogadaj);
                        unosDogadaja.ShowDialog();
                        OsvjeziDogadaje();
                    }
                }
                else
                {
                        unosDogadajaForma unosDogadaja = new unosDogadajaForma(odabraniDogadaj);
                        unosDogadaja.ShowDialog();
                        OsvjeziDogadaje();
                    
                }
               
                
            }

        }
        //klikom na gumb Izbrisi dogadaj, brise se odabrani dogadaj iz datagridviewa
        private void btnObrisiDogadaj_Click(object sender, EventArgs e)
        {
            if (dgvDogadaji.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDogadaji.SelectedRows)
                {
                    Dogadaj odabraniDogadaj = row.DataBoundItem as Dogadaj;
                    if (PrijavaForma.prijavljeniKorisnik.ulogaKorisnika_iduloga > 1)
                    {
                        if (odabraniDogadaj.idKorisnik != PrijavaForma.prijavljeniKorisnik.idKorisnik)
                        {
                            MessageBox.Show("Niste kreirali odabrani događaj za brisanje!");
                        }
                        else
                        {
                            DogadajiRepozitorij.Izbrisi(odabraniDogadaj);
                        }
                    }
                    else
                    {
                        DogadajiRepozitorij.Izbrisi(odabraniDogadaj);
                    }

                        
                }
            }
            OsvjeziDogadaje();
        }

        //metoda putem koje se osvjezava prikaz dogadaja u tablici
        private void OsvjeziDogadaje()
        {
            List<Dogadaj> listaDogadaja = DogadajiRepozitorij.DohvatiDogadaje();
            dgvDogadaji.DataSource = listaDogadaja;
        }

  

        //na ucitavanje kontrole dogadaji ucitava se metoda osvjezidogadaje
        private void DogadajiKontrola_Load(object sender, EventArgs e)
        {
            OsvjeziDogadaje();
       

        }

        private List<Dogadaj> trazilicaDogadaja(string naziv)
        {
            List<Dogadaj> listaD = new List<Dogadaj>();
            foreach (Dogadaj s in DogadajiRepozitorij.DohvatiDogadaje())
            {
                if (s.ImeDogadaj.Contains(naziv))
                {
                    listaD.Add(s);

                }
            }
            return listaD;

        }

        private void txtBoxTraziDogadaj_TextChanged(object sender, EventArgs e)
        {
            dgvDogadaji.DataSource = trazilicaDogadaja(txtBoxTraziDogadaj.Text);
        }
    }
}
