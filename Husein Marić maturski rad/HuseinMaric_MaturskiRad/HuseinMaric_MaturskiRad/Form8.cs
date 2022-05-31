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
    
 
    public partial class Form8 : Form
    {
        string a;
        Class3 class3 = new Class3();
        public Form8(string nazivP)
        {
            InitializeComponent();
            a = nazivP;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;
            textBox5.Text = a;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label1.Text = "Ime";
            label2.Text = "Prezime";
            label3.Text = "Broj telefona";
            label4.Text = "Napomena";
            label5.Text = "Naziv proizvoda";
            button1.Font = new Font("Verdana", 15);
            button2.Font = new Font("Verdana", 15);
            button1.Text = "NARUČI ";
            button2.Text = "OTKAŽI";
            button1.Enabled = false;
         

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sugurni da ste tacno unijeli podatke", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                

                class3.Ime = textBox1.Text;
                class3.Prezime = textBox2.Text;
                class3.BrojTelefona = textBox3.Text;
                class3.Napomena = textBox4.Text;
                class3.Proizvod = textBox5.Text;
                bool var = class3.Insert(class3);
                if (var == true)
                {
                    MessageBox.Show("Vaša narudžba je uspješno pohranjena. Bit ćete uskoro kontaktirani");

                }
                else
                {
                    MessageBox.Show("Došlo je do greške. Molimo Vas da pokušate ponovo");

                }
            }
            else
            {
                
            }
          
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
