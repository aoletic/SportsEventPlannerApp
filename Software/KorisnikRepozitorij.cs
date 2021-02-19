using SportsEventPlanner.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventPlanner
{
    public partial class KorisnikRepozitorij
    {
        List<Korisnik> listaKorisnika = new List<Korisnik>();

        public KorisnikRepozitorij()
        {
            
        }
        //definiranje liste korisnika
        public static Korisnik DohvatiKorisnike(SqlDataReader dr, List<Uloga> listaUloga)
        {
            Uloga uloga = null;
            Korisnik korisnik = null;
            if (dr != null)
            {
                uloga = new Uloga();
                korisnik = new Korisnik();
                korisnik.idKorisnik = int.Parse(dr["idkorisnik"].ToString());
                korisnik.imeKorisnika = dr["ime_korisnika"].ToString();
                korisnik.prezimeKorisnika = dr["prezime_korisnika"].ToString();
                korisnik.korisnickoIme = dr["korisnicko_ime"].ToString();
                korisnik.email = dr["email"].ToString();
                korisnik.lozinka = dr["lozinka"].ToString();
                korisnik.kontakt = dr["kontakt"].ToString();
                korisnik.ulogaKorisnika_iduloga = int.Parse(dr["ulogakorisnika_id_uloga"].ToString());

            }
            return korisnik;
        }

        //dohvacanje liste korisnika uz pomoc SQL-a
        public List<Korisnik> DohvatiKorisnike()
        {
            List<Uloga> listaUloga = new List<Uloga>();
            listaUloga = DohvatiUlogeKorisnika();
            List<Korisnik> lista = new List<Korisnik>();
            string sqlUpit = "SELECT * from korisnik";
            SqlDataReader dr = Data.Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Korisnik korisnik = DohvatiKorisnike(dr, listaUloga);
                lista.Add(korisnik);
            }
            dr.Close(); //DataReader treba obavezno zatvoriti nakon uporabe.
            return lista;
        }

        //dohvacanje uloge korisnika uz pomoc SQL-a
        public List<Uloga> DohvatiUlogeKorisnika()
        {
            List<Uloga> listaUloga = new List<Uloga>();
            string sqlUpit = $"SELECT * FROM ulogakorisnika";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Uloga uloga = DohvatiUlogu(dr);
                listaUloga.Add(uloga);
            }
            dr.Close();
            return listaUloga;
        }

        private Uloga DohvatiUlogu(SqlDataReader dr)
        {
            Uloga uloga = null;
            if (dr != null)
            {

                uloga = new Uloga();
                uloga.Id_uloga = int.Parse(dr["id_uloga"].ToString());
                uloga.Naziv_uloge = dr["naziv_uloge"].ToString();

            }
            return uloga;
        }

    }
}
