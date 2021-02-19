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
    public partial class PrijavaNatjecanje : UserControl
    {
        public PrijavaNatjecanje()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void PrijavaNatjecanje_Load(object sender, EventArgs e)
        {

        }
    }
}
