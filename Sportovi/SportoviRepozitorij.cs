using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sportovi
{
    public partial class SportoviRepozitorij
    {
        public static List<Sport> DohvatiSportove()
        {
            List<Sport> lista = new List<Sport>();
            string sqlUpit = "SELECT * FROM sportovi";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Sport Sport = new Sport();
                lista.Add(Sport);
            }
            dr.Close(); //DataReader treba obavezno zatvoriti nakon uporabe.
            return lista;
        }

        //metoda za dohvažanje sportova za prikaz unutar datagridviewa
        public static List<Sport> DohvatiSportovePrikaz()
        {
            List<Sport> lista = new List<Sport>();
            string sqlUpit = "SELECT idsport, nazivsport, brojclanovautimu FROM sportovi";
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Sport Sport = new Sport();
                Sport.IdSport = int.Parse(dr["idsport"].ToString());
                Sport.NazivSport = dr["nazivsport"].ToString();
                Sport.BrojClanovaTim = int.Parse(dr["brojclanovautimu"].ToString());
                lista.Add(Sport);
            }
            dr.Close(); //DataReader treba obavezno zatvoriti nakon uporabe.
            return lista;
        }

        // metoda koja služi za dodavanje ili ažuriranje sportova za unos sportova
        public static int SpremiSport(Sport sport, int idKorisnik)
        {
            string sqlUpit = "";
            if (sport.IdSport == 0) //Unos novog
            {
                sqlUpit = "INSERT INTO sportovi (nazivsport, brojclanovautimu, korisnikid )" +
                    "VALUES('" + sport.NazivSport + "','" + sport.BrojClanovaTim + "', '" + idKorisnik + "')";
            }
            else
            {
                sqlUpit = "UPDATE sportovi set nazivsport= '" + sport.NazivSport + "', brojclanovautimu= '" + sport.BrojClanovaTim + "'  where idsport= " + sport.IdSport;
            }
            return Database.Instance.IzvrsiUpit(sqlUpit);

        }

        //metoda za brisanje sportova

        public static int ObrisiSport(Sport sport)
        {
            string sqlDelete = "DELETE FROM sportovi WHERE idsport = " + sport.IdSport;
            return Database.Instance.IzvrsiUpit(sqlDelete);
        }
    }
}
