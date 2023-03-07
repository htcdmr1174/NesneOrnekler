﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] dizi;
        int satirSayisi;
        int sutunSayisi;
        private void button1_Click(object sender, EventArgs e)
        {
            int rasgeleMin = int.Parse(textBox3.Text);
            int rastgeleMax = int.Parse(textBox4.Text);
            satirSayisi = int.Parse(textBox1.Text);
            sutunSayisi = int.Parse(textBox2.Text);
            dizi = new int[satirSayisi, sutunSayisi];
            Random rastgele = new Random();
            for (int x = 0; x < satirSayisi; x++)
            {
                for (int y = 0; y < sutunSayisi; y++)
                {
                    dizi[x, y] = rastgele.Next(rasgeleMin, rastgeleMax);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                for (int x = 0; x < satirSayisi; x++)
                {
                    for (int y = 0; y < sutunSayisi; y++)
                    {
                        listBox1.Items.Add(x + "," + y + "=>" + dizi[x, y]);
                    }
                }
            }
        }
    }
}
