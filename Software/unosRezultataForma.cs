using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsEventPlanner
{
    public partial class unosRezultataForma : Form
    {
        UtakmiceRepozitorij utakmiceRepozitorij = new UtakmiceRepozitorij();
        private Utakmica Utakmica = null;

        public unosRezultataForma()
        {
            InitializeComponent();
            
        }

        public unosRezultataForma (Utakmica odabranaUtakmica)
        {
            InitializeComponent();

            Utakmica = odabranaUtakmica;

        }

        private void unosRezultataForma_Load(object sender, EventArgs e)
        {
            txtBoxBrojPoenaTim1.Text = "";
            txtBoxBrojPoenaTim2.Text = "";

        }

        private void btnSpremiRezultat_Click(object sender, EventArgs e)
        {
            if (Utakmica == null)
            {

                Utakmica = new Utakmica();
            }
            if (txtBoxBrojPoenaTim1.Text == "" || txtBoxBrojPoenaTim2.Text == "")
            {
                MessageBox.Show("Unesite rezultate");
            }
            else
            {


                try
                {


                    Utakmica.brojPoenaTim1 = txtBoxBrojPoenaTim1.Text;
                    Utakmica.brojPoenaTim2 = txtBoxBrojPoenaTim2.Text;
                    UtakmiceRepozitorij.DodajRezultat(Utakmica);
                    UtakmiceRepozitorij.UpdateTim(Utakmica);
                    UtakmiceRepozitorij.UpdateTim2(Utakmica);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Nisu ispravno unseni podaci!");
                }
            }


        }

        private void txtBoxBrojPoenaTim1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxBrojPoenaTim1.Text, "[^0-9]"))
            {
                MessageBox.Show("Ne možete upisivati slova u rezultat!");
                txtBoxBrojPoenaTim1.Text = txtBoxBrojPoenaTim1.Text.Remove(txtBoxBrojPoenaTim1.Text.Length - 1);
            }
        }

        private void txtBoxBrojPoenaTim2_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxBrojPoenaTim2.Text, "[^0-9]"))
            {
                MessageBox.Show("Ne možete upisivati slova u rezultat!");
                txtBoxBrojPoenaTim2.Text = txtBoxBrojPoenaTim2.Text.Remove(txtBoxBrojPoenaTim2.Text.Length - 1);
            }
        }
    }
}
