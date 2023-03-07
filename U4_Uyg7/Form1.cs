using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[3];
        int[,] notlar = new int[3, 4];
        int index = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            double toplam;
            for (int x = 0; x < 3; x++)
            {
                toplam = 0;
                for (int y = 0; y < 4; y++)
                {
                    toplam += notlar[x, y];
                }
                listBox1.Items.Add(isimler[x] + "=>" + toplam / 4);

            }
        }
    }
}
