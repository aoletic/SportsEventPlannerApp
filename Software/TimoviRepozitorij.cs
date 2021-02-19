
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventPlanner
{
    public partial class TimoviRepozitorij
    {
        //definiranje liste timova
        public static Tim DohvatiTimove(SqlDataReader dr)
        {
            Tim tim = null;
            if (dr != null)
            {
                tim = new Tim();
                tim.idTim = int.Parse(dr["idtim"].ToString());
                tim.imeTima = dr["imetima"].ToString();
                tim.kontaktBroj = dr["kontaktbroj"].ToString();
                tim.dogadajid = int.Parse(dr["dogadajid"].ToString());
                tim.korisnikid = int.Parse(dr["korisnikid"].ToString());
                tim.pobjedio = dr["pobjedio"].ToString();
            }
            return tim;
        }
        
        //dohvacanje timova u listu timova gdje je dogadajid trazeni dogadaj
        public static List<Tim> DohvatiTimove(int dogadaj)
        {
            List<Tim> lista = new List<Tim>();
            string sqlUpit = "SELECT * FROM timovi where dogadajid =" + dogadaj;
            SqlDataReader dr = Data.Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read()) 
            {
                Tim tim = DohvatiTimove(dr);
                lista.Add(tim);
            }
            dr.Close();
            return lista;
        }



        //metoda koja dodaje tim
        public static int DodajTim(Tim tim)
        {
            string sqlUpit = "";
            if (tim.idTim == 0)
            {
                sqlUpit = "INSERT into timovi (idtim, imetima, kontaktbroj, dogadajid,  korisnikid ) VALUES ('" + tim.idTim + "', '" + tim.imeTima + "', '" + tim.kontaktBroj + "','" + tim.dogadajid
                    + "', '" + tim.korisnikid + "')";
            }
            else
            {
                sqlUpit = "UPDATE timovi SET imetima='" + tim.imeTima + "', kontaktbroj='" + tim.kontaktBroj + "', dogadajid='"
                     + tim.dogadajid + "', korisnikid='" + tim.korisnikid + "' where idtim = '" + tim.idTim;
            }
            return Data.Database.Instance.IzvrsiUpit(sqlUpit);
        }

        //metoda koja brise tim
        public static int ObrisiTim(Tim tim)
        {
            string sqlDelete = "DELEte FROM timovi WHERE idtim=" + tim.idTim;
            return Data.Database.Instance.IzvrsiUpit(sqlDelete);

        }


    }
}
