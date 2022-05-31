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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Skladistar";
            button2.Text = "Kupac";
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\husei\Desktop\MojMaturskiRad\slike-za-forme\skladistar.png");
            this.BackgroundImage = myimage;
            button2.Visible = false;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\husei\Desktop\MojMaturskiRad\slike-za-forme\GlavnaForma1.png");
            this.BackgroundImage = myimage;
            button2.Visible = true;
        }

        private void Button2_MouseHover(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\husei\Desktop\MojMaturskiRad\slike-za-forme\kupac.png");
            this.BackgroundImage = myimage;
            button1.Visible = false;
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\husei\Desktop\MojMaturskiRad\slike-za-forme\GlavnaForma1.png");
            this.BackgroundImage = myimage;
            button1.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
