using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            decimal cpuFiyat = 0;
            if (radioButton1.Checked)
                cpuFiyat = 5000;
            else if (radioButton2.Checked)
                cpuFiyat = 4500;
            else if (radioButton3.Checked)
                cpuFiyat = 3000;
            else if (radioButton4.Checked)
                cpuFiyat = 2000;
            else if (radioButton5.Checked)
                cpuFiyat = 1000;
            tabanFiyat += cpuFiyat;
            decimal ramFiyat = 0;
            if (radioButton6.Checked)
                ramFiyat = 3500;
            else if (radioButton7.Checked)
                ramFiyat = 2500;
            else if (radioButton8.Checked)
                ramFiyat = 1000;
            tabanFiyat += ramFiyat;

            decimal diskfiyat = 0;
            if (radioButton9.Checked)
                diskfiyat = 2500;
            else if (radioButton10.Checked)
                diskfiyat = 1500;
            else if (radioButton11.Checked)
                diskfiyat = 1000;
            tabanFiyat += diskfiyat;

            decimal ekdFiyat = 0;
            if (checkBox1.Checked)
                ekdFiyat = 3000;
            if (checkBox2.Checked)
                ekdFiyat = 2000;
            if (checkBox3.Checked)
                ekdFiyat = 1000;
            tabanFiyat += ekdFiyat;

            MessageBox.Show(string.Format("toplam fiyat {0:C}", tabanFiyat));



        }
    }
}
