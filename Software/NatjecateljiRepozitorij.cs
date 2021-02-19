using SportsEventPlanner.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SportsEventPlanner
{
    public class NatjecateljiRepozitorij
    {

        //definiranje liste natjecatelja
        public static Natjecatelj DohvatiNatjecatelje(SqlDataReader dr)
        {
            Natjecatelj natjecatelj = null;
            if (dr != null)
            {
                natjecatelj = new Natjecatelj();
                natjecatelj.imeNatjecatelj = dr["imenatjecatelja"].ToString();
                natjecatelj.prezimeNatjecatelj = dr["prezimenatjecatelja"].ToString();
                // natjecatelj.oib = int.Parse(dr["oib"].ToString());    TREBA BIG INT PRETVORIT U STRING?
              
            }
            return natjecatelj;
        }

        //koristi se za dohvacanje natjecatelja u listu natjecatelj
        public static List<Natjecatelj> DohvatiNatjecatelje(int tim)
        {
            List<Natjecatelj> lista = new List<Natjecatelj>();
            string sqlUpit = "SELECT imenatjecatelja, prezimenatjecatelja FROM natjecatelji left join natjecateljitiimovi on idnatjecatelj=natjecateljid where timid=" + tim;
            SqlDataReader dr = Data.Database.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Natjecatelj natjecatelj = DohvatiNatjecatelje(dr);
                lista.Add(natjecatelj);
            }
            dr.Close();
            return lista;
        }




    }
}
