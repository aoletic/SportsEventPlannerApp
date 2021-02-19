using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventPlanner
{
    /*Klasa u kojoj je definiran događaj*/
    public partial class Dogadaj
    {
        public int IdDogadaj { get; set; }
        public string ImeDogadaj { get; set; }
        public string DatumPocetkaDogadaj { get; set; }
        public string DatumZavrsetkaDogadaj { get; set; }
        public int MinBrojTimova { get; set; }
        public int MaxBrojTimova { get; set; }
        public int idSporta { get; set; }
        public int idKorisnik { get; set; }



        public Dogadaj()
        {
        }

        public override string ToString()
        {
            return ImeDogadaj;
        }


    }
}
