using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace SportsEventPlanner
{
    public partial class DogadajiRepozitorij
    {
        /*Definiranje liste dogadaj*/
        public static Dogadaj DohvatiDogadaje(SqlDataReader dr)
        {
            Dogadaj Dogadaj = null;
            if (dr != null)
            {
                Dogadaj = new Dogadaj();
                Dogadaj.IdDogadaj = int.Parse(dr["iddogadaj"].ToString());
                Dogadaj.ImeDogadaj = dr["imedogadaj"].ToString();
                Dogadaj.DatumPocetkaDogadaj = dr["datumpocetka"].ToString();
                Dogadaj.DatumZavrsetkaDogadaj = dr["datumzavrsetka"].ToString();
                Dogadaj.MinBrojTimova = int.Parse(dr["minbrojtimova"].ToString());
                Dogadaj.MaxBrojTimova = int.Parse(dr["maxbrojtimova"].ToString());
                Dogadaj.idSporta = int.Parse(dr["sportid"].ToString());
                Dogadaj.idKorisnik = int.Parse(dr["korisnikid"].ToString());
            }
            return Dogadaj;
        }

        /*Koristi se za dohvaćanje događaja u listu dogadaj*/
        public static List<Dogadaj> DohvatiDogadaje()
        {
            List<Dogadaj> lista = new List<Dogadaj>();
            string sqlUpit = "SELECT * FROM dogadaji";
            SqlDataReader dr = Data.Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Dogadaj Dogadaj = DohvatiDogadaje(dr);
                lista.Add(Dogadaj);
            }
            dr.Close(); //DataReader treba obavezno zatvoriti nakon uporabe.
            return lista;
        }

        // metoda koja sprema dogadaj bilo kod unosa novog dogadaja ili kod azuriranja starog   
        public static int Spremi(Dogadaj Dogadaj)
        {
            string sqlUpit = "";
            if (Dogadaj.IdDogadaj == 0) //Unos novog
            {
                sqlUpit = "INSERT INTO dogadaji (imedogadaj, datumpocetka, datumzavrsetka, minbrojtimova, maxbrojtimova, sportid, korisnikid)" +
                    "VALUES('" + Dogadaj.ImeDogadaj + "','" + DateTime.Parse(Dogadaj.DatumPocetkaDogadaj).ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                    DateTime.Parse(Dogadaj.DatumZavrsetkaDogadaj).ToString("yyyy-MM-dd HH:mm:ss")
                    + "', '" + Dogadaj.MinBrojTimova + "', '" + Dogadaj.MaxBrojTimova + "' , '" + Dogadaj.idSporta + "', '" + Dogadaj.idKorisnik + "')";
            }
            else //Ažuriranje starog
            {
                sqlUpit = "UPDATE dogadaji SET imedogadaj='" + Dogadaj.ImeDogadaj + "', datumpocetka='" + DateTime.Parse(Dogadaj.DatumPocetkaDogadaj).ToString("yyyy-MM-dd HH:mm:ss") + "', datumzavrsetka='"
                     + DateTime.Parse(Dogadaj.DatumZavrsetkaDogadaj).ToString("yyyy-MM-dd HH:mm:ss") + "', minbrojtimova='" + Dogadaj.MinBrojTimova + "', maxbrojtimova='" + Dogadaj.MaxBrojTimova + "' , sportid = '" +
                       Dogadaj.idSporta + "' where iddogadaj = " + Dogadaj.IdDogadaj;
            }
            return Data.Database.Instance.IzvrsiUpit(sqlUpit);


        }
        // metoda koja brise dogadaj
        public static int Izbrisi(Dogadaj Dogadaj)
        {
            string sqlDelete = "DELETE FROM dogadaji WHERE iddogadaj = " + Dogadaj.IdDogadaj;
            return Data.Database.Instance.IzvrsiUpit(sqlDelete);

        }


    }
}
