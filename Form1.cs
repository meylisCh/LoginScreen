using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            string kullanıcıAdı, sifre;
            kullanıcıAdı = txtbox1.Text;
            sifre = txtbox2.Text;
            if (kullanıcıAdı == "meylis" && sifre == "charyyev")
            {
                f2.Show();
                MessageBox.Show("hoşgeldin");
            }
            else
            {
                MessageBox.Show("Kulanıcı adı veya Şifre hatalı");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //test
            Console.WriteLine("test");
        }
    }
}
