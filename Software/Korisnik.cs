using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventPlanner
{
    //klasa u kojoj je definiran korisnik
    public partial class  Korisnik
    {
        public int idKorisnik { get; set; }
        public string imeKorisnika { get; set; }
        public string prezimeKorisnika { get; set; }
        public string korisnickoIme { get; set; }
        public string email { get; set; }
        public string lozinka { get; set; }
        public string kontakt { get; set; }
        public int ulogaKorisnika_iduloga { get; set; }

        public Korisnik()
        {
            
        }
        public Korisnik(int idkorisnik, string imekorisnika, string prezimekorisnika, string korisnickoime, string email, string lozinka, string kontakt, int ulogakorisnika)
        {
            idKorisnik = idkorisnik;
            imeKorisnika = imekorisnika;
            prezimeKorisnika = prezimekorisnika;
            korisnickoIme = korisnickoime;
            this.email = email;
            this.lozinka = lozinka;
            this.kontakt = kontakt;
            ulogaKorisnika_iduloga = ulogakorisnika;
        }
    }
}
