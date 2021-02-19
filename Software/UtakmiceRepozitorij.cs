using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SportsEventPlanner.Data;
using System.Windows.Forms;

namespace SportsEventPlanner
{
    public partial class UtakmiceRepozitorij
    {
        //definiranje liste utakmice
        public static Utakmica DohvatiUtakmice(SqlDataReader dr)
        {
            Utakmica utakmica = null;
            if (dr != null)
            {
                utakmica = new Utakmica();
                utakmica.idUtakmice = int.Parse(dr["idutakmice"].ToString());
                utakmica.idTima1 = int.Parse(dr["tim1id"].ToString());
                utakmica.idTima2 = int.Parse(dr["tim2id"].ToString());

                utakmica.korisnikId = int.Parse(dr["korisnikid"].ToString());
                utakmica.dogadajId = int.Parse(dr["dogadajid"].ToString());
                utakmica.brojPoenaTim1 = dr["brojpoenatim1"].ToString();
                utakmica.brojPoenaTim2 = dr["brojpoenatim2"].ToString();





            }
            return utakmica;
        }

        //metoda vraca sve utakmice sa trazenim dogadajem
        public static List<Utakmica> DohvatiUtakmice(int dogadaj)
            {
            List<Utakmica> lista = new List<Utakmica>();
            string sqlUpit = "SELECT * from utakmice where dogadajid=" +dogadaj;
            SqlDataReader dr = Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Utakmica utakmica = DohvatiUtakmice(dr);
                lista.Add(utakmica);
            }
            dr.Close();
            return lista;
        }




        //metoda dodaje novu utakmicu u tablicu
        public static int DodajUtakmicu(Utakmica utakmica)
        {
            string sqlUpit = "";
            sqlUpit = "insert into utakmice(korisnikid, dogadajid, tim1id, tim2id, brojpoenatim1, brojpoenatim2) VALUES('"+ utakmica.korisnikId + "', '" + utakmica.dogadajId + "', '" 
                + utakmica.idTima1 + "', '"+ utakmica.idTima2 +"' , DEFAULT , DEFAULT )";
            return Data.Database.Instance.IzvrsiUpit(sqlUpit);
        }

        //metoda koja unosi rezultat za utakmicu
        public static int DodajRezultat(Utakmica utakmica)
        {
            string sqlUpit = "";
            if(utakmica.brojPoenaTim1 == utakmica.brojPoenaTim2)
            {
                MessageBox.Show("Rezultat je izjednačen, nema pobjednika!");
                return 0;
            }

            sqlUpit = "UPDATE utakmice SET brojpoenatim1 ='" + utakmica.brojPoenaTim1 + "', brojpoenatim2= '" + utakmica.brojPoenaTim2 + "' where idutakmice =" + utakmica.idUtakmice;
                
            
            return Data.Database.Instance.IzvrsiUpit(sqlUpit);
        }

        //metoda putem koje se update stupac pobjedio u tablici za tim1 te se uz njegovu pomoć u drugoj metodi kreiraju utakmice
        public static int UpdateTim(Utakmica utakmica)
        {
            string sqlUpdate = "";

            if(Convert.ToInt32(utakmica.brojPoenaTim1) > Convert.ToInt32(utakmica.brojPoenaTim2))
            {
                sqlUpdate = "UPDATE timovi set pobjedio='da' where idtim=" + utakmica.idTima1;
            }
            else
            {
                sqlUpdate = "UPDATE timovi set pobjedio='da' where idtim=" + utakmica.idTima2;
            }

            return Data.Database.Instance.IzvrsiUpit(sqlUpdate);
        }

        //metoda putem koje se update stupac pobjedio u tablici za tim2 te se uz njegovu pomoć u drugoj metodi kreiraju utakmice
        public static int UpdateTim2(Utakmica utakmica)
        {
            string sqlUpdate2 = "";

            if (Convert.ToInt32(utakmica.brojPoenaTim1) > Convert.ToInt32(utakmica.brojPoenaTim2))
            {
                sqlUpdate2 = "UPDATE timovi set pobjedio='ne' where idtim=" + utakmica.idTima2;
            }
            else
            {
                sqlUpdate2 = "UPDATE timovi set pobjedio='ne' where idtim=" + utakmica.idTima1;
            }

            return Data.Database.Instance.IzvrsiUpit(sqlUpdate2);
        }

        //metoda koja brise rezultata za utakmicu
        public static int ObrisiRezultat(Utakmica utakmica)
        {
            string sqlDelete = "";
            sqlDelete = "UPDATE utakmice set brojpoenatim1 = '-', brojpoenatim2 = '-' where idutakmice = "+ utakmica.idUtakmice;
            return Data.Database.Instance.IzvrsiUpit(sqlDelete);
        }
        //metoda koja azurira rezultat za utakmicu
        public static void AzurirajRezultat(Utakmica utakmica)
        {

        }
    }
}
