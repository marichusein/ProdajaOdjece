using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

using System.Configuration;
using System.Data.SqlClient;

namespace HuseinMaric_MaturskiRad
{
    public partial class Form5 : Form
    {
        Class2 cs = new Class2();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button1.Text = "Izbrisi proizvod";
            DataTable dt = cs.Select();
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int red = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[red].Cells[0].Value.ToString();
            byte []image = (byte[])dataGridView1.Rows[red].Cells[5].Value;
            MemoryStream ms = new MemoryStream(image);
            Image slic = Image.FromStream(ms);
            pictureBox1.Image = slic;
           
            
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cs.ID = Convert.ToInt32( textBox1.Text);
           bool var= cs.Delete(cs);
            if (var == true)
            {
                MessageBox.Show("Uspjesno obrisan prozvod");
                dataGridView1.DataSource = cs.Select();
            }
            else
            {

                MessageBox.Show("Greska");
            }

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;

            DataTable dt = new DataTable();
            string pretraga = textBox2.Text;
            SqlConnection connection = new SqlConnection(conn);
            string sql = "SELECT * FROM Odjeca WHERE Naziv LIKE '%" + pretraga + "%'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
