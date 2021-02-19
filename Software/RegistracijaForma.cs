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
   
    // otvara se help pritiskom na tipku F1
    public partial class RegistracijaForma : Form
    {
        string path = Directory.GetCurrentDirectory();

        static string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName);
        string startupPath2 = startupPath + "//Software//Pomoc.chm";
        public RegistracijaForma()
        {
            InitializeComponent();
            helpProvider2.HelpNamespace = startupPath2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        //klikom na gumb Registriraj se otvara se forma za prijavu
        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            PrijavaForma prijava = new PrijavaForma();
            this.Hide();
            prijava.ShowDialog();
            this.Close();
        }
    }
}
