using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Ogrenciler ogrenci = new Ogrenciler();
                ogrenci.Numara = 1111;
                ogrenci.AdSoyad = "Mehmet";
                ogrenci.Alan = "Bilişim Teknolojileri";
                textBox1.DataBindings.Add("Text", ogrenci, "numara");
                textBox2.DataBindings.Add("Text", ogrenci, "adSoyad");
                textBox4.DataBindings.Add("Text", ogrenci, "alan");
            }
        }
    }
}
