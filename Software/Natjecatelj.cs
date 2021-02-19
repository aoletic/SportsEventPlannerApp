using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventPlanner
{
    //klasa za definiranje natjecatelja
    public class Natjecatelj
    {
        public int idNatjecatelj { get; set; }
        public string imeNatjecatelj { get; set; }
        public string prezimeNatjecatelj { get; set; }
        public int oib { get; set; }
        public string email { get; set; }
        public DateTime datumRodenja { get; set; }
        public string kontaktTelefon { get; set; }

        public Natjecatelj() 
        {

        }
    }
}
