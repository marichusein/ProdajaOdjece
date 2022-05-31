using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace HuseinMaric_MaturskiRad
{
    public partial class Form7 : Form
    {
        Class2 class2 = new Class2();
        public Form7()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGridView1.DataSource = class2.SelectCijena();
            }
            else
            {
                dataGridView1.DataSource = class2.SelecKupca();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = class2.SelectPrekoJoina();
            checkBox1.Text = "Roba jeftinija od 25KM";
            checkBox1.BackColor = Color.Transparent;
            label1.Text = "Cijena: ";
            label1.Font = new Font("Verdana", 10);
            label1.BackColor = Color.Transparent;
            textBox1.ReadOnly = true;
            label2.Text = "Unesite naziv prozvoda: ";
            label2.Font = new Font("Verdana", 10);
            label2.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            button1.Text = "Naruči";
        }
        string proizvodNaziv;
        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int red = e.RowIndex;
            byte[] image = (byte[])dataGridView1.Rows[red].Cells[2].Value;
            MemoryStream ms = new MemoryStream(image);
            Image slic = Image.FromStream(ms);
            pictureBox1.Image = slic;
            textBox1.Text = dataGridView1.Rows[red].Cells[1].Value.ToString()+" KM";
            textBox1.Font = new Font("Verdana", 8);
            proizvodNaziv = dataGridView1.Rows[red].Cells[0].Value.ToString();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["konekcija"].ConnectionString;

            DataTable dt = new DataTable();
            string pretraga = textBox2.Text;
            SqlConnection connection = new SqlConnection(conn);
            string sql = "select od.Naziv,od.Cijena,od.Slika,vrsta.Naziv as 'Vrsta garderobe',oni.Naziv as 'Marka' from Odjeca as od join VrtsaOdjece as vrsta on od.VrstaID=vrsta.ID join Marka as oni on od.MarkaID=oni.ID WHERE od.Naziv LIKE '%" + pretraga + "%'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(proizvodNaziv);
            form8.Show();
        }
    }
}
