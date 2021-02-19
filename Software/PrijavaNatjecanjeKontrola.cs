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
    public partial class PrijavaNatjecanjeKontrola : UserControl
    {
        public PrijavaNatjecanjeKontrola()
        {
            InitializeComponent();
        }


        //klikom na gumb otvara se forma za dodavanje timova
        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            dodajTimForma dodajTim = new dodajTimForma();
            dodajTim.ShowDialog();
        }

        //klikom na gumb otvara se forma za dodavanje natjecatelja
        private void btnDodajNatjecatelja_Click(object sender, EventArgs e)
        {
            unosNatjecateljaForma unosNatjecatelja = new unosNatjecateljaForma();
            unosNatjecatelja.ShowDialog();

        }
    }
}
