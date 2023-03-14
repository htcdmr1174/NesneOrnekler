using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown3_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                textBox4.Text = "";
                textBox4.Text += textBox1.Text + "\r\n";
                textBox4.Text += textBox2.Text + "\r\n";
                textBox4.Text += textBox3.Text + "\r\n";
                decimal hesap = 0;
                if (numericUpDown1.Value > 0)
                {
                    hesap += numericUpDown1.Value * 12;
                    textBox4.Text += string.Format("Çorba { 0:C}", numericUpDown1.Value * 12) + "\r\n";
                }
                textBox4.Text += "----------";
                textBox4.Text += string.Format("toplam {0:C}",hesap);

            }
        }
    }
}
