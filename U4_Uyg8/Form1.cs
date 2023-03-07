using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[,] dizi = new byte[4, 4];
        private void button2_Click(object sender, EventArgs e)
        {
            Random rasgele = new Random();
            int satırRasgele = rasgele.Next(4);
            int sutunRasgele = rasgele.Next(4);
            dizi[satırRasgele, sutunRasgele] = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte satır = byte.Parse(textBox1.Text);
            byte sutun = byte.Parse(textBox2.Text);
            PictureBox kutu = this.Controls.Find("p" + satır + sutun, true)[0] as PictureBox;
            byte durum = dizi[satır, sutun];
            if (durum == 0)
            { kutu.BackColor = Color.Green; }
            else
            { kutu.BackColor = Color.Red; }
        }
    }
}
