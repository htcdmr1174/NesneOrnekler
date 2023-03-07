using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }

                textBox2.Text = enyuksek.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int endusuk = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
               if (notlar[i] < endusuk)
                    endusuk = notlar[i];
            }
            textBox3. Text = endusuk. ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];

            }
            ortalama = toplam / notlar.Length;
            button4.Text = ortalama.ToString();
            }
         
    }       
}
