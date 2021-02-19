using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventPlanner
{
    //klasa za definiranje timova
    public partial class Tim
    {
        public int idTim { get; set; }
        public string imeTima { get; set; }
        public string kontaktBroj { get; set; }

        public string pobjedio { get; set; }

        public int dogadajid { get; set; }
        public int korisnikid { get; set; }

        //konstruktor za kreiranje novog tima
        public Tim() { 
        }
        
    }
}
