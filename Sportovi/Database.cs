using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Sportovi
{
    public class Database
    {
        private static Database instance; //Singleton objekt
        private string connectionString; //Putanja i ostali podaci za spajanje na bazu
        private SqlConnection connection; //Konekcija prema bazi
        public static Database Instance //Singleton instanca klase za rad za bazom.
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }
        public string ConnectionString //Putanja i ostali podaci za spajanje na bazu
        {
            get { return connectionString; }
            private set { connectionString = value; }
        }
        public SqlConnection Connection //Konekcija prema bazi
        {
            get { return connection; }
            private set { connection = value; }
        }
        private Database() //Konstruktor klase
        {
            ConnectionString = @"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=PI20_055_DB; User=PI20_055_User; Password=pg]kWIXZ";
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();

        }
        public void CloseConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
        /// <summary>
        /// Dohvaća podatke u obliku DataReader objekta na temelju proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Rezultati upita.</returns>
        public SqlDataReader DohvatiDataReader(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }
        /// <summary>
        /// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita.
        /// /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Skalarna vrijednost kao rezultat upita.</returns>
        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }
        /// <summary>
        /// Izvršava INSERT, UPDATE, DELETE SQL izraz.
        /// </summary>
        /// <param name="sqlUpit">INSERT, UPDATE, DELETE SQL izraz.</param>
        /// <returns>Broj redaka u tablici koji su promijenjeni.</returns>
        public int IzvrsiUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
