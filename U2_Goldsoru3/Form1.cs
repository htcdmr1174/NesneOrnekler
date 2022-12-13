using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Goldsoru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox2.Text = "";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, ortalama;
            not1 = Convert.ToInt16(textBox1.Text);
            not2 = Convert.ToInt16(textBox2.Text);
            not3 = Convert.ToInt16(textBox3.Text);

            ortalama = (not1 + not2 + not3) / 3;
            label3.Text = ortalama.ToString(); 
            if (radioButton1.Checked == true)
            {
                label1.Text = ("matematik");
            }
            else if (radioButton1.Checked == true)
            {
                label1.Text = ("türkçe");
            }
            else if (radioButton1.Checked == true)
            {
                label1.Text = ("nesne tabanlı");
            }
            else
            {
                label1.Text = ("robotik kodlama");
            }
            else
        }
             
        }
    }

