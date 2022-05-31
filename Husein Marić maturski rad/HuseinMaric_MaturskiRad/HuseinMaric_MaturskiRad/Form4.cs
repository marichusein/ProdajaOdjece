using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;

namespace HuseinMaric_MaturskiRad
{
    public partial class Form4 : Form
    {

        Class1 cs = new Class1();
        Class2 class2 = new Class2();
      
        public Form4()
        {
            InitializeComponent();
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cs.SelectMarke();
            DataTable dt1 = new DataTable();
            dt1 = cs.SelectVrste();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "ID";
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = "ID";
            label1.Text = "Naziv";
            label2.Text = "Marka";
            label3.Text = "Vrsta";
            label4.Text = "Cijena";
            label5.Text = "Slika";
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            button1.Text = "Dodaj";
            button2.Text = "DODAJ PROIZVOD";
            textBox3.ReadOnly = true;
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openFileDialog1.FileName;
                Image image =Image.FromFile(textBox3.Text);

                pictureBox1.Image = image;

                comboBox1.DisplayMember = "ID";
                comboBox2.DisplayMember = "ID";
               
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            
           
            textBox3.Text = openFileDialog1.FileName;
            Image image = Image.FromFile(textBox3.Text);
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);
            memoryStream.ToArray();
            class2.Naziv = textBox1.Text;
            class2.MarkaID = Convert.ToInt32( comboBox1.Text);
            class2.VrstaID = Convert.ToInt32(comboBox2.Text);
            class2.Cijena = textBox2.Text;
            class2.Slika= memoryStream.ToArray();
            bool var = class2.Insert(class2);
            if (var == true)
            {
                MessageBox.Show("Uspjesno dodan proizvod");

            }
            else
            {
                MessageBox.Show("Greska");

            }
            comboBox2.DisplayMember = "Naziv";
            comboBox1.DisplayMember = "Naziv";
        }


        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
