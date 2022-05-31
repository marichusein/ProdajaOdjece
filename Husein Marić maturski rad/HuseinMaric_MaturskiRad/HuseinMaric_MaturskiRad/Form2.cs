using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuseinMaric_MaturskiRad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = "Prijavi se";
            textBox2.Font = new Font("Verdana", 15);
            textBox1.Font = new Font("Verdana", 15);
            button1.Font = new Font("Verdana", 25);
            

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '°';
            
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="user" && textBox2.Text == "user")
            {
                MessageBox.Show("Uspjesna prijava");
                Form3 form = new Form3();
                form.Show();
            }
            else
            {
                MessageBox.Show("Greska");

            }
        }
    }
}
