using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_GoldSoru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] ortalamalar = new int[30];
       

        private void button5_Click(object sender, EventArgs e)
        {
            int enYüksek = 0;
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] > enYüksek)
                {
                    enYüksek = ortalamalar[i];
                    
                }
                label1.Text = enYüksek.ToString();
            }

            
         }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                listBox1.Items.Add(ortalamalar[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                ortalamalar[i] = random.Next(0, 101);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i]<50)
                {
                   listBox1.Items.Add(ortalamalar[i]);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i] > 70 && ortalamalar[i] < 100) 
                {
                    listBox1 .Items .Add (ortalamalar[i]);
                    
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                toplam += ortalamalar[i];
            }
            label1.Text = (toplam / ortalamalar.Length).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int endusuk = ortalamalar[0];
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if  (ortalamalar[i] < endusuk)
                {
                    endusuk = ortalamalar[i];
                }
                label1.Text = "en düşük "+endusuk.ToString();

            }
        }


        int gecensayisi;
        private void button7_Click(object sender, EventArgs e)
        {
            gecensayisi = 0;
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i]>50)
                {
                    gecensayisi++;

                }
                label1.Text ="gecen sayisi" +gecensayisi .ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int kalanogrenci = 0;
            for (int i = 0; i < ortalamalar.Length; i++)
            {
                if (ortalamalar[i]<50)
                {
                    kalanogrenci++;
                }
                label1.Text ="kalan ogrenci"+ kalanogrenci .ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int basariorani = (100 * gecensayisi) / ortalamalar.Length;
            label1.Text = "basari oranı = %" + basariorani.ToString();
        }
    } 
}
