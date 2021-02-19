using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventPlanner
{
    public static class Validacija
    {

        //metoda u kojoj dohvaćamo korisnika te pozivamo metodu za validiranje podataka
        public static Korisnik IzvrsiPrijavu(string korisnickoIme, string lozinka)
        {
            KorisnikRepozitorij repozitorij = new KorisnikRepozitorij();
            List<Korisnik> listaKorisnika = new List<Korisnik>();
            listaKorisnika = repozitorij.DohvatiKorisnike();
            return ValidirajPodatke(korisnickoIme, lozinka, listaKorisnika);
        }

        // metoda koja pretražuje postoji li u listi korisnika korisnik s traženim korisničkim imenom i lozinkom

        public static Korisnik ValidirajPodatke(string korisnickoIme, string lozinka, List<Korisnik> listaKorisnika)
        {
            Korisnik validiraniKorisnik = null;
            validiraniKorisnik = listaKorisnika.Find(item => item.korisnickoIme == korisnickoIme);
            if (validiraniKorisnik != null)
            {
                if (validiraniKorisnik.lozinka == lozinka)
                {
                    return validiraniKorisnik;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
