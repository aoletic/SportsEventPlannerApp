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
    public partial class PregledTimovaNatjecateljaKontrola : UserControl
    {
        int id;
        public PregledTimovaNatjecateljaKontrola()
        {
            InitializeComponent();
            
        }

        //kod otvaranja kontrole, dogadaji se ucitavaju u combobox
        private void PregledTimovaNatjecateljaKontrola_Load(object sender, EventArgs e)
        {
            cmbOdabirDogadaja.DataSource = DogadajiRepozitorij.DohvatiDogadaje();
            txtBoxNatjecateljTrazi.Hide();

        }

        //kod odabira dogadaja u comboboxu, timovi se ucitavaju u datagridview timovi
        private void cmbOdabirDogadaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dogadaj dogadaj = cmbOdabirDogadaja.SelectedItem as Dogadaj;
            dgvTimovi.DataSource=TimoviRepozitorij.DohvatiTimove(dogadaj.IdDogadaj);
            dgvTimovi.Columns[3].Visible = false;
            dgvNatjecatelji.DataSource = null;
            


        }

        //kod duplog klika na red u datagridu timovi, u datagridview natjecatelji se ucitavaju natjecatelji koji imaju id tog kliknutog tima
        private void dgvTimovi_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTimovi.SelectedRows)
                {
                    Tim tim = row.DataBoundItem as Tim;
                    dgvNatjecatelji.DataSource = NatjecateljiRepozitorij.DohvatiNatjecatelje(tim.idTim);
                    id = tim.idTim;
                    dgvNatjecatelji.Columns[0].Visible = false;
                    dgvNatjecatelji.Columns[3].Visible = false;
                    dgvNatjecatelji.Columns[4].Visible = false;
                    dgvNatjecatelji.Columns[5].Visible = false;
                    dgvNatjecatelji.Columns[6].Visible = false;
                }
                txtBoxNatjecateljTrazi.Show();
            }

        }

        //trazilica putem koje se traze timovi
        private List<Tim> trazilicaTimova(string naziv)
        {
            Dogadaj dogadaj = cmbOdabirDogadaja.SelectedItem as Dogadaj;
            List<Tim> listaT = new List<Tim>();
            foreach (Tim s in TimoviRepozitorij.DohvatiTimove(dogadaj.IdDogadaj))
            {
                if (s.imeTima.Contains(naziv))
                {
                    listaT.Add(s);

                }
            }
            return listaT;

        }



        private void txtBoxTimoviTrazi_TextChanged(object sender, EventArgs e)
        {
            dgvTimovi.DataSource = trazilicaTimova(txtBoxTimoviTrazi.Text);
        }

        //trazilica putem koje se traze natjecatelji
        private List<Natjecatelj> trazilicaNatjecatelja(string naziv)
        {
            
            List<Natjecatelj> listaN = new List<Natjecatelj>();
            foreach (Natjecatelj s in NatjecateljiRepozitorij.DohvatiNatjecatelje(id))
            {
                if (s.imeNatjecatelj.Contains(naziv) || s.prezimeNatjecatelj.Contains(naziv))
                {
                    listaN.Add(s);

                }
            }
            return listaN;

        }
        
        private void txtBoxNatjecateljTrazi_TextChanged(object sender, EventArgs e)
        {
            dgvNatjecatelji.DataSource = trazilicaNatjecatelja(txtBoxNatjecateljTrazi.Text);

        }

    }
}
