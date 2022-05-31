using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HuseinMaric_MaturskiRad
{
    class Class1
    {
        public int ID { get; set; }
        public string Naziv { get; set; }

        static string conn = ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;

        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(conn);
            string sql = "SELECT * FROM Marka ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable SelectMarke()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(conn);
            string sql = "SELECT * FROM Marka ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
            
            return dt;
        }
        public DataTable SelectSlike()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(conn);
            string sql = "SELECT Naziv FROM Slika ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);

            return dt;
        }
        public DataTable SelectVrste()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(conn);
            string sql = "SELECT * FROM VrtsaOdjece";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);

            return dt;
        }
    }
}
