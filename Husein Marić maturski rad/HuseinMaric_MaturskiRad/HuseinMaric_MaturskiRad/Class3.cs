using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace HuseinMaric_MaturskiRad
{
    class Class3
    {
        public int NarudzbaID { get; set; }
        public string Proizvod { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Napomena { get; set; }
        static string conn = ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;
        public bool Insert(Class3 c)
        {
            bool varijabla = true;
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                string sql = "INSERT INTO Narudzba(Proizvod, Ime, Prezime, BrojTelefona, Napomena) VALUES(@Proizvod, @Ime, @Prezime, @BrojTelefona, @Napomena)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Proizvod", c.Proizvod);
                command.Parameters.AddWithValue("@Ime", c.Ime);
                command.Parameters.AddWithValue("@Prezime", c.Prezime);
                command.Parameters.AddWithValue("@BrojTelefona", c.BrojTelefona);
                command.Parameters.AddWithValue("@Napomena", c.Napomena);

                connection.Open();
                int red = command.ExecuteNonQuery();
                if (red > 0)
                {
                    varijabla = true;
                }
                else
                {
                    varijabla = false;
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return varijabla;
        }



    }
}
