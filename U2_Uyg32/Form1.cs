using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi;
            long parola;

            try
            {
                kullaniciAdi = textBox1.Text.ToString();
                parola = long.Parse(textBox2.Text.ToString());
                MessageBox.Show("Giriş Başarılı. Hoşgeldiniz " + kullaniciAdi);
            }
            catch (Exception)
            {
                MessageBox.Show("sifreniz sadece sayılardan oluşmalıdır Tekrar deneyiniz.");
                textBox2.Text = "";
            }
            finally
            { }
        }
    }
}

