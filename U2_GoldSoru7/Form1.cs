using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int kuçuk,buyuk;
            int buyukIndeks = 0;
            kuçuk = Convert.ToInt32(listBox1.Items[0]);
            buyuk = Convert.ToInt32(listBox1.Items[0]);
            int sayi;
            for (int i = 0; i <  listBox1 .Items .Count ; i++)
            {
                sayi = Convert.ToInt32(listBox1.Items[i]);
                if (buyuk < sayi)
                {
                    buyuk = sayi ;
                    buyukIndeks = i;

                }
                if (kuçuk > buyuk)
                {
                    kuçuk = buyuk;
                }
            }
            label2.Text = buyuk.ToString();
            label4.Text = kuçuk.ToString();
            listBox1.SelectedIndex = buyukIndeks;
            












        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();

            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(random.Next(1,100));
            }






        }

        private void button3_Click(object sender, EventArgs e)
        {


           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 1; i < 20; i++)
            {
                listBox1.Items.Add(random.Next(1,100));
            }

        }
    }
}
