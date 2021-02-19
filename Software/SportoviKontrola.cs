using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sportovi;

namespace SportsEventPlanner
{
    public partial class SportoviKontrola : UserControl
    {
        public SportoviKontrola()
        {
            InitializeComponent();
            if (PrijavaForma.uloga > 1)
            {
                btnDodajSport.Hide();
                btnAzurirajSport.Hide();
                btnObrisiSport.Hide();
            }
        }

        //osvjezavanje prikaza sportova
        private void OsvjeziSportove()
        {
            List<Sport> listaSportova = SportoviRepozitorij.DohvatiSportovePrikaz();
            dgvSportovi.DataSource = listaSportova;
            
        }

        private void SportoviKontrola_Load(object sender, EventArgs e)
        {
            OsvjeziSportove();
        }
        //trazilica putem koje se pretrazuju sportovi
        private List<Sport> trazilicaSportova (string naziv)
        {
            List<Sport> listaS = new List<Sport>();
            foreach (Sport s in SportoviRepozitorij.DohvatiSportovePrikaz() )
            {
                if (s.NazivSport.Contains(naziv))
                {
                    listaS.Add(s);
                    
                }
            }
            return listaS;
            
        }
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            dgvSportovi.DataSource = trazilicaSportova(txtBoxSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          foreach (DataGridViewRow row in dgvSportovi.Rows )
            {
                
                if(!row.Cells[1].Value.ToString().Contains(txtBoxSearch.Text))
                {
                    row.Visible = false;
                }
            }

        }

        private void btnDodajSport_Click(object sender, EventArgs e)
        {
            unosSportovaForma unosSportova = new unosSportovaForma();
            unosSportova.ShowDialog();
            OsvjeziSportove();
        }

        private void btnAzurirajSport_Click(object sender, EventArgs e)
        {
            if (dgvSportovi.SelectedRows.Count > 0)
            {
                Sport odabraniSport = dgvSportovi.CurrentRow.DataBoundItem as Sport;
                unosSportovaForma unosSportova = new unosSportovaForma(odabraniSport);
                unosSportova.ShowDialog();
                OsvjeziSportove();
            }
        }

        private void btnObrisiSport_Click(object sender, EventArgs e)
        {
            if (dgvSportovi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSportovi.SelectedRows)
                {
                    Sport odabraniSport = row.DataBoundItem as Sport;
                    SportoviRepozitorij.ObrisiSport(odabraniSport);
                }
            }
            OsvjeziSportove();
        }
    }
}
