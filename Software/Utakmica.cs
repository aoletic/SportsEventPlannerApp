using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventPlanner
{
    //klasa za definiranje utakmice
    public partial class Utakmica
    {
        public int idUtakmice { get; set; }
        public int idTima1 { get; set; }
        public int idTima2 { get; set; }

        public string pocetakUtakmice { get; set; }
        public string brojPoenaTim1 { get; set; }
        public string brojPoenaTim2 { get; set; }

        public int korisnikId { get; set; }
        public int dogadajId { get; set; }

        public Utakmica()
        {

        }
    }
}
