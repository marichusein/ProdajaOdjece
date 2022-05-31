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
    class Class2
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int VrstaID { get; set; }
        public int MarkaID { get; set; }
        public string Cijena { get; set; }
        public byte[] Slika { get; set; }
        static string conn = ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(conn);
            string sql = "SELECT * FROM Odjeca ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
            return dt;
        }

        public bool Insert(Class2 c)
        {
            bool varijabla = true;
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                string sql = "INSERT INTO Odjeca(Naziv, VrstaID, MarkaID, Cijena, Slika) VALUES(@Naziv, @VrstaID, @MarkaID, @Cijena, @Slika)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Naziv", c.Naziv);
                command.Parameters.AddWithValue("@VrstaID", c.VrstaID);
                command.Parameters.AddWithValue("@MarkaID", c.MarkaID);
                command.Parameters.AddWithValue("@Cijena", c.Cijena);
                command.Parameters.AddWithValue("@Slika", c.Slika);

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


        public bool Delete(Class2 cs)
        {
            bool varijabla = true;
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                string sql = "DELETE FROM Odjeca WHERE ID=@ID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ID", cs.ID);
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
        public Image byteArrayToImage(byte[] byteArrayIn)
        {


            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Write(byteArrayIn, 0, byteArrayIn.Length);
            Image returnImage = Image.FromStream(ms, true);
            return returnImage;

        }
        public DataTable SelectCijena()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(conn);
            string sql = "select od.Naziv,od.Cijena,od.Slika,vrsta.Naziv as 'Vrsta garderobe',oni.Naziv as 'Marka' from Odjeca as od join VrtsaOdjece as vrsta on od.VrstaID=vrsta.ID join Marka as oni on od.MarkaID=oni.ID WHERE Cijena <30 ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable SelecKupca()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(conn);
            string sql = "SELECT Naziv, Cijena, Slika FROM Odjeca";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable SelectPrekoJoina()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(conn);
            string sql = "select od.Naziv,od.Cijena,od.Slika,vrsta.Naziv as 'Vrsta garderobe',oni.Naziv as 'Marka' from Odjeca as od join VrtsaOdjece as vrsta on od.VrstaID=vrsta.ID join Marka as oni on od.MarkaID=oni.ID ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
            return dt;
        }
    }
}
